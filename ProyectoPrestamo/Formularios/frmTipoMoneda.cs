using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modales;
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

namespace ProyectoPrestamo.Formularios
{
    public partial class frmTipoMoneda : Form
    {
        public frmTipoMoneda()
        {
            InitializeComponent();
        }

        private void frmTipoMoneda_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            List<TipoMoneda> lista = TipoMonedaLogica.Instancia.Listar(out mensaje);

            foreach (TipoMoneda tm in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    tm.IdTipoMoneda,
                    tm.Divisa,
                    tm.Abreviatura,
                    "",
                    ""
                });
            }

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            using (var form = new mdTipoMoneda())
            {
                form.Editar = false;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvdata.Rows.Add(new object[] {
                        form.oTipoMoneda.IdTipoMoneda,
                        form.oTipoMoneda.Divisa,
                        form.oTipoMoneda.Abreviatura,
                        "",
                        ""
                    });
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete16.Width;
                var h = Properties.Resources.delete16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;

            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btneditar")
                {
                    using (var form = new mdTipoMoneda())
                    {
                        form.Editar = true;
                        form.oTipoMoneda = new TipoMoneda()
                        {
                            IdTipoMoneda = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString()),
                            Divisa = dgvdata.Rows[index].Cells["Divisa"].Value.ToString(),
                            Abreviatura = dgvdata.Rows[index].Cells["Abreviatura"].Value.ToString(),
                        };

                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            dgvdata.Rows[index].Cells["Divisa"].Value = form.oTipoMoneda.Divisa;
                            dgvdata.Rows[index].Cells["Abreviatura"].Value = form.oTipoMoneda.Abreviatura;
                        }
                    }

                }
                else if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {

                    if (MessageBox.Show("¿Desea eliminar el tipo de moneda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        int _id = int.Parse(dgvdata.Rows[index].Cells["Id"].Value.ToString());

                        int validar = TipoMonedaLogica.Instancia.Validar(_id, out mensaje);
                        if (validar > 0)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        
                        int respuesta = TipoMonedaLogica.Instancia.Eliminar(_id);
                        if (respuesta > 0)
                        {
                            dgvdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el tipo de moneda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
    }
}
