using ProyectoPrestamo.Herramientas;
using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamo.Modales
{
    public partial class mdClientes : Form
    {
        public string _nombrecompleto { get; set; }
        public string _tipodocumento { get; set; }
        public string _nrodocumento { get; set; }
        public string _direccion { get; set; }
        public string _ciudad { get; set; }
        public string _correo { get; set; }
        public string _telefono { get; set; }

        public mdClientes()
        {
            InitializeComponent();
        }

        private void mdClientes_Load(object sender, EventArgs e)
        {
            var lista = ClienteLogica.Instancia.Listar();
            foreach (Clientes item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.NombreCompleto,
                    item.TipoDocumento,
                    item.NumeroDocumento,
                    item.Direccion,
                    item.Ciudad,
                    item.Correo,
                    item.NumeroTelefono
                });
            }

            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
                {
                    _nombrecompleto = dgvdata.Rows[index].Cells["NombreCompleto"].Value.ToString();
                    _tipodocumento = dgvdata.Rows[index].Cells["TipoDocumento"].Value.ToString();
                    _nrodocumento = dgvdata.Rows[index].Cells["NumeroDocumento"].Value.ToString();
                    _direccion = dgvdata.Rows[index].Cells["Direccion"].Value.ToString();
                    _ciudad = dgvdata.Rows[index].Cells["Ciudad"].Value.ToString();
                    _correo = dgvdata.Rows[index].Cells["Correo"].Value.ToString();
                    _telefono = dgvdata.Rows[index].Cells["NumeroTelefono"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
