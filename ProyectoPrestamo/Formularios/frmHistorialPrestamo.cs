using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modales;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamo.Formularios
{
    public partial class frmHistorialPrestamo : Form
    {
        static string _clausulas = string.Empty;
        public frmHistorialPrestamo()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistorialPrestamo_Load(object sender, EventArgs e)
        {
            rbnumerooperacion.Checked = true;
            rbdocumentocliente.Checked = false;
            txtnumerooperacion.Enabled = true;
            txtdocumentocliente.Enabled = false;
            lblnrooperacion.Text = "";
            lblestadoprestamo.Text = "";
        }

        private void rbnumerooperacion_CheckedChanged(object sender, EventArgs e)
        {
            txtnumerooperacion.Enabled = true;
            txtnumerooperacion.Text = "";
            txtnumerooperacion.Focus();

            txtdocumentocliente.Enabled = false;
            txtdocumentocliente.Text = "";
        }

        private void rbdocumentocliente_CheckedChanged(object sender, EventArgs e)
        {
            txtnumerooperacion.Enabled = false;
            txtnumerooperacion.Text = "";

            txtdocumentocliente.Enabled = true;
            txtdocumentocliente.Text = "";
            txtdocumentocliente.Focus();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string numerooperacion = string.Empty;
            string documentocliente = string.Empty;

            if (rbnumerooperacion.Checked)
            {
                if (txtnumerooperacion.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                numerooperacion = txtnumerooperacion.Text;
            }
            else
            {
                if (txtdocumentocliente.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                documentocliente = txtdocumentocliente.Text;
            }

            Prestamo obj = PrestamoLogica.Instancia.Obtener(numerooperacion, documentocliente);

            if (obj.IdPrestamo != 0)
            {
                txtidprestamo.Text = obj.IdPrestamo.ToString();
                lblnrooperacion.Text = obj.NumeroOperacion;

                txtclientenombre.Text = obj.NombreCliente;
                txtclientetipodocumento.Text = obj.TipoDocumento;
                txtclientedocumento.Text = obj.NumeroDocumento;
                txtclientedireccion.Text = obj.Direccion;
                txtclienteciudad.Text = obj.Ciudad;
                txtclientecorreo.Text = obj.Correo;
                txtclientetelefono.Text = obj.NumeroTelefono;

                txtmontoprestamo.Text = obj.MontoPrestamo;
                txtinteres.Text = obj.Interes;
                txtnumerocuotas.Text = obj.NumeroCuotas.ToString();

                txtformapago.Text = obj.oTipoPago.Descripcion;
                txttipomoneda.Text = obj.oTipoMoneda.Abreviatura;
                txtfechainicio.Text = obj.FechaInicio;

                txtmontoxcuota.Text = obj.MontoCuota;
                txttotalinteres.Text = obj.TotalIntereses;
                txtmontototalpagar.Text = obj.MontoTotal;

                _clausulas = obj.Clausula;

                lblestadoprestamo.Text = obj.Estado;
                if (obj.Estado == "CANCELADO")
                    lblestadoprestamo.ForeColor = Color.Firebrick;
                else if (obj.Estado == "CERRADO")
                    lblestadoprestamo.ForeColor = Color.RoyalBlue;
                else
                    lblestadoprestamo.ForeColor = Color.ForestGreen;

                dgvdata.Rows.Clear();
                List<Cuota> listaPeriodo = CuotaLogica.Instancia.Listar(obj.IdPrestamo);
                int index = 0;
                foreach (Cuota item in listaPeriodo)
                {

                    dgvdata.Rows.Add(new object[] {
                        item.IdCuota.ToString(),
                        item.NumeroCuota.ToString(),
                        item.FechaPagoCuota,
                        item.MontoCuota.ToString("0.00"),
                        item.EstadoCuota,
                        "",
                        item.FechaPago
                    });

                    if (item.EstadoCuota == "PENDIENTE")
                    {
                        dgvdata.Rows[index].Cells[4].Style.BackColor = Color.Red;
                        dgvdata.Rows[index].Cells[4].Style.ForeColor = Color.White;
                    }
                    else {
                        dgvdata.Rows[index].Cells[4].Style.BackColor = Color.LimeGreen;
                        dgvdata.Rows[index].Cells[4].Style.ForeColor = Color.White;
                    }
                    index++;
                }
                dgvdata.ClearSelection();

               
            }
            else
            {
                limpiar(false);
                MessageBox.Show("No se encontraron resultados con los datos de búsqueda solicitados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void limpiar(bool aplica = true)
        {
            if (aplica)
            {
                txtnumerooperacion.Text = "";
                txtdocumentocliente.Text = "";
            }
            

            txtidprestamo.Text = "0";
            lblnrooperacion.Text = "";

            txtclientenombre.Text = "";
            txtclientetipodocumento.Text = "";
            txtclientedocumento.Text = "";
            txtclientedireccion.Text = "";
            txtclienteciudad.Text = "";
            txtclientecorreo.Text = "";
            txtclientetelefono.Text = "";

            txtmontoprestamo.Text = "";
            txtinteres.Text = "";
            txtnumerocuotas.Text = "";

            txtformapago.Text = "";
            txttipomoneda.Text = "";
            txtfechainicio.Text = "";

            txtmontoxcuota.Text = "";
            txttotalinteres.Text = "";
            txtmontototalpagar.Text = "";

            lblestadoprestamo.Text = "";
            _clausulas = "";
            dgvdata.Rows.Clear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.download20.Width;
                var h = Properties.Resources.download20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.download20, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnclausulas_Click(object sender, EventArgs e)
        {
            using (var form = new mdClausulas())
            {
                form.Clausulas = _clausulas;
                form.txtclausulas.ReadOnly = true;
                form.btnguardar.Visible = false;
                form.btncancelar.Text = "Aceptar";
                form.btncancelar.Focus();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _clausulas = form.Clausulas;
                }
            }
        }

        private void btndescargarresumen_Click(object sender, EventArgs e)
        {
            if (txtidprestamo.Text == "0") {
                MessageBox.Show("No se encontraron datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaInformacion.ToString();
            Datos da = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nrooperacion", lblnrooperacion.Text);

            Texto_Html = Texto_Html.Replace("@nombrerazonsocial", da.RazonSocial);
            Texto_Html = Texto_Html.Replace("@correo", da.Correo);
            Texto_Html = Texto_Html.Replace("@ruc", da.RUC);
            Texto_Html = Texto_Html.Replace("@telefono", da.Telefono);
            Texto_Html = Texto_Html.Replace("@representante", da.Representante);


            Texto_Html = Texto_Html.Replace("@nombrecompleto", txtclientenombre.Text);
            Texto_Html = Texto_Html.Replace("@tipodoc", txtclientetipodocumento.Text);
            Texto_Html = Texto_Html.Replace("@nrodoc", txtclientedocumento.Text);
            Texto_Html = Texto_Html.Replace("@direccion", txtclientedireccion.Text);
            Texto_Html = Texto_Html.Replace("@ciudad", txtclienteciudad.Text);
            Texto_Html = Texto_Html.Replace("@correoc", txtclientecorreo.Text);
            Texto_Html = Texto_Html.Replace("@telefonoc", txtclientetelefono.Text);


            Texto_Html = Texto_Html.Replace("@fechainicio", txtfechainicio.Text);
            Texto_Html = Texto_Html.Replace("@formapago", txtformapago.Text);
            Texto_Html = Texto_Html.Replace("@tipomoneda", txttipomoneda.Text);
            Texto_Html = Texto_Html.Replace("@montoprestamo", txtmontoprestamo.Text);
            Texto_Html = Texto_Html.Replace("@interes", txtinteres.Text);
            Texto_Html = Texto_Html.Replace("@nrocuotas", txtnumerocuotas.Text);
            Texto_Html = Texto_Html.Replace("@montoxcuota", txtmontoxcuota.Text);
            Texto_Html = Texto_Html.Replace("@totalintereses", txttotalinteres.Text);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototalpagar.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["NumeroCuota"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["FechaPago"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["MontoCuota"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@clausulas", _clausulas);



            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Informacion_{0}.pdf", lblnrooperacion.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
                    if (obtenido) {
                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.GetRight(60), pdfDoc.GetTop(60) - 21);
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtidprestamo.Text == "0")
            {
                MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lblestadoprestamo.Text != "EN CURSO")
            {
                MessageBox.Show("Esta opción no está habilitado para préstamos con estado \"" + lblestadoprestamo.Text + "\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            


            using (var form = new mdModificarPrestamo())
            {
                form._nombrecompleto = txtclientenombre.Text;
                form._tipodocumento = txtclientetipodocumento.Text;
                form._nrodocumento = txtclientedocumento.Text;
                form._direccion = txtclientedireccion.Text;
                form._ciudad = txtclienteciudad.Text;
                form._telefono = txtclientetelefono.Text;
                form._correo = txtclientecorreo.Text;
                form._clausulas = _clausulas;
                form._idprestamo = Convert.ToInt32(txtidprestamo.Text);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtclientenombre.Text = form._nombrecompleto;
                    txtclientetipodocumento.Text = form._tipodocumento;
                    txtclientedocumento.Text = form._nrodocumento;
                    txtclientedireccion.Text = form._direccion;
                    txtclienteciudad.Text = form._ciudad;
                    txtclientetelefono.Text = form._telefono ;
                    txtclientecorreo.Text = form._correo;
                    _clausulas = form._clausulas;

                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            if (txtidprestamo.Text == "0")
            {
                MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lblestadoprestamo.Text != "EN CURSO")
            {
                MessageBox.Show("Esta opción no está habilitado para préstamos con estado \"" + lblestadoprestamo.Text + "\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            using (var form = new mdCancelarPrestamo())
            {
                form._numeroOperacion = lblnrooperacion.Text;
                form._idprestamo = Convert.ToInt32(txtidprestamo.Text);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblestadoprestamo.Text =  "CANCELADO";
                    lblestadoprestamo.ForeColor = Color.Firebrick;

                }
            }

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btnDescargar")
                {
                    if (dgvdata.Rows[index].Cells["Estado"].Value.ToString() != "PENDIENTE")
                    {

                        Datos da = DatoLogica.Instancia.Obtener();
                        string Texto_Html = Properties.Resources.PlantillaRecibo.ToString();
                        Texto_Html = Texto_Html.Replace("@nrooperacion", lblnrooperacion.Text);
                        Texto_Html = Texto_Html.Replace("@fechapago", dgvdata.Rows[index].Cells["FechaPagoC"].Value.ToString());

                        Texto_Html = Texto_Html.Replace("@nombrerazonsocial", da.RazonSocial);
                        Texto_Html = Texto_Html.Replace("@ruc", da.RUC);

                        Texto_Html = Texto_Html.Replace("@nombrecompleto", txtclientenombre.Text);
                        Texto_Html = Texto_Html.Replace("@tipodoc", txtclientetipodocumento.Text);
                        Texto_Html = Texto_Html.Replace("@nrodoc", txtclientedocumento.Text);

                        Texto_Html = Texto_Html.Replace("@tipomoneda", txttipomoneda.Text);
                        Texto_Html = Texto_Html.Replace("@nrocuota", dgvdata.Rows[index].Cells["NumeroCuota"].Value.ToString());
                        Texto_Html = Texto_Html.Replace("@montototal", dgvdata.Rows[index].Cells["MontoCuota"].Value.ToString() );


                        SaveFileDialog savefile = new SaveFileDialog();
                        savefile.FileName = string.Format("Recibo_{0}_{1}.pdf", lblnrooperacion.Text, dgvdata.Rows[index].Cells["NumeroCuota"].Value.ToString());
                        savefile.Filter = "Pdf Files|*.pdf";

                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                            {
                                //Creamos un nuevo documento y lo definimos como PDF
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                bool obtenido = true;
                                byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
                                if (obtenido)
                                {
                                    //Agregamos la imagen del banner al documento
                                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                                    img.ScaleToFit(60, 60);
                                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                    img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(60));
                                    pdfDoc.Add(img);
                                }

                                using (StringReader sr = new StringReader(Texto_Html))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                }

                                pdfDoc.Close();
                                stream.Close();
                                MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else {
                        MessageBox.Show("La descarga solo está habilitado para cuotas con estado \"CANCELADO\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    
                }
            }
        }
    }
}
