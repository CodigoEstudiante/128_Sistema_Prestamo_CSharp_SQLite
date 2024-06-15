using ProyectoPrestamo.Modelo;
using ProyectoPrestamo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ProyectoPrestamo.Herramientas;
using ClosedXML.Excel;

namespace ProyectoPrestamo.Formularios
{
    public partial class frmResumenGeneral : Form
    {
        public frmResumenGeneral()
        {
            InitializeComponent();
        }
        private void frmResumenGeneral_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true)
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Clear();

            DateTime dt1 = Convert.ToDateTime(txtfechainicio.Value.ToString("dd/MM/yyyy"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin.Value.ToString("dd/MM/yyyy"));
            List<VistaReporte> lista = PrestamoLogica.Instancia.Resumen(dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")), dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")));

            foreach (VistaReporte vr in lista) {

                dgvdata.Rows.Add(new object[] {
                    vr.NroOperacion,
                    vr.Estado,
                    vr.FechaRegistro,
                    vr.FormaPago,
                    vr.TipoMoneda,
                    vr.FechaInicio,
                    vr.MontoPrestamo,
                    vr.Interes,
                    vr.NroCuotas,
                    vr.MontoporCuota,
                    vr.TotalInteres,
                    vr.MontoTotal,
                    vr.NombreCliente,
                    vr.TipoDocumento,
                    vr.NroDocumento,
                    vr.Direccion,
                    vr.Ciudad,
                    vr.Correo,
                    vr.NroTelefonoCelular
                });
            }
            
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
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

        private void btnborrarbusqueda_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnborrarfiltro_Click(object sender, EventArgs e)
        {
            txtfechainicio.Value = DateTime.Now;
            txtfechafin.Value = DateTime.Now;

            dgvdata.Rows.Clear();
        }

        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata.Columns)
                    dt.Columns.Add(column.HeaderText, typeof(string));

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    dt.Rows.Add(new object[] {
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        row.Cells[7].Value.ToString(),
                        row.Cells[8].Value.ToString(),
                        row.Cells[9].Value.ToString(),
                        row.Cells[10].Value.ToString(),
                        row.Cells[11].Value.ToString(),
                        row.Cells[12].Value.ToString(),
                        row.Cells[13].Value.ToString(),
                        row.Cells[14].Value.ToString(),
                        row.Cells[15].Value.ToString(),
                        row.Cells[16].Value.ToString(),
                        row.Cells[17].Value.ToString(),
                        row.Cells[18].Value.ToString()
                    });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Resumen_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }
    }
}
