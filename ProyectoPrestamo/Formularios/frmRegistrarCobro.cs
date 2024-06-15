using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamo.Formularios
{
    public partial class frmRegistrarCobro : Form
    {
        public frmRegistrarCobro()
        {
            InitializeComponent();
        }

        private void frmRegistrarCobro_Load(object sender, EventArgs e)
        {
            rbnrooperacion.Checked = true;
            rbdocumentocliente.Checked = false;
            txtnrooperacion.Enabled = true;
            txtnrodocumento.Enabled = false;
            lblnrooperacion.Text = "";
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string numerooperacion = string.Empty;
            string documentocliente = string.Empty;

            if (rbnrooperacion.Checked)
            {
                if (txtnrooperacion.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                numerooperacion = txtnrooperacion.Text;
            }
            else
            {
                if (txtnrodocumento.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                documentocliente = txtnrodocumento.Text;
            }

            Prestamo obj = PrestamoLogica.Instancia.Obtener(numerooperacion, documentocliente);

            if (obj.IdPrestamo != 0)
            {
                if (obj.Estado == "EN CURSO")
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
                    txtnrocuotas.Text = obj.NumeroCuotas.ToString();

                    txtformapago.Text = obj.oTipoPago.Descripcion;
                    txttipomoneda.Text = obj.oTipoMoneda.Abreviatura;
                    txtfechainicio.Text = obj.FechaInicio;

                    txtmontoxcuota.Text = obj.MontoCuota;
                    txtmontointeres.Text = obj.TotalIntereses;
                    txtmontototal.Text = obj.MontoTotal;


                    Cuota _cuota = CuotaLogica.Instancia.Listar(obj.IdPrestamo).Where(c => c.ProximoPago == 1).FirstOrDefault();

                    txtidcuota.Text = _cuota.IdCuota.ToString();
                    txtcuotapagar.Text = _cuota.NumeroCuota.ToString();
                    txtfechalimite.Text = _cuota.FechaPagoCuota;
                    txtimportepagar.Text = _cuota.MontoCuota.ToString();
                }
                else {

                    MessageBox.Show(string.Format("No se pueden registrar pagos para una operación con estado \"{0}\"",obj.Estado), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                txtnrooperacion.Text = "";
                txtnrodocumento.Text = "";
            }


            txtidprestamo.Text = "0";
            txtidcuota.Text = "0";

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
            txtnrocuotas.Text = "";

            txtformapago.Text = "";
            txttipomoneda.Text = "";
            txtfechainicio.Text = "";

            txtmontoxcuota.Text = "";
            txtmontointeres.Text = "";
            txtmontototal.Text = "";

            txtidcuota.Text = "";
            txtcuotapagar.Text = "";
            txtfechalimite.Text = "";
            txtimportepagar.Text = "";

        }

        private void rbnrooperacion_CheckedChanged(object sender, EventArgs e)
        {
            txtnrooperacion.Enabled = true;
            txtnrooperacion.Text = "";
            txtnrooperacion.Focus();

            txtnrodocumento.Enabled = false;
            txtnrodocumento.Text = "";
        }

        private void rbdocumentocliente_CheckedChanged(object sender, EventArgs e)
        {
            txtnrooperacion.Enabled = false;
            txtnrooperacion.Text = "";

            txtnrodocumento.Enabled = true;
            txtnrodocumento.Text = "";
            txtnrodocumento.Focus();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar(true);
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (Convert.ToInt32(txtidprestamo.Text) == 0) {
                MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            int nrooperaciones = PrestamoLogica.Instancia.Pagar(new Cuota() {
                    IdCuota = Convert.ToInt32(txtidcuota.Text),
                    FechaPago = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                    NumeroCuota = Convert.ToInt32(txtcuotapagar.Text)
                },
                Convert.ToInt32(txtidprestamo.Text),
                Convert.ToInt32(txtnrocuotas.Text),
                out mensaje
            );

            if (nrooperaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                limpiar(true);
                MessageBox.Show("Se registro el pago correctamente\nPuedes descargar el recibo en \"Historial Préstamo\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
