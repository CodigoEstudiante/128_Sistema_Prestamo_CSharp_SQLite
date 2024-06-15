using ProyectoPrestamo.Herramientas;
using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modales;
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
    public partial class frmRegistrarPrestamo : Form
    {
        private static List<TipoPago> listaPago = new List<TipoPago>();
        private static List<Cuota> ListaCuota = new List<Cuota>();
        static string clausulas;
        public frmRegistrarPrestamo()
        {
            InitializeComponent();
        }

        private void frmRegistrarPrestamo_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int idcorrelativo = PrestamoLogica.Instancia.ObtenerCorrelativo(out mensaje);

            if (idcorrelativo < 1)
            {
                txtnumerooperacion.Text = "";
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                txtnumerooperacion.Text = String.Format("{0:000000}", idcorrelativo);

            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtclientenombre.Focus();


            listaPago = TipoPagoLogica.Instancia.Listar(out mensaje);
            foreach (TipoPago item in listaPago)
            {
                cbotipopago.Items.Add(new OpcionCombo() { Valor = item.IdTipoPago, Texto = item.Descripcion });
            }
            cbotipopago.DisplayMember = "Texto";
            cbotipopago.ValueMember = "Valor";
            cbotipopago.SelectedIndex = 0;


            var listamoneda = TipoMonedaLogica.Instancia.Listar(out mensaje);
            foreach (TipoMoneda item in listamoneda)
            {
                cbotipomoneda.Items.Add(new OpcionCombo() { Valor = item.IdTipoMoneda, Texto = item.Abreviatura });
            }
            cbotipomoneda.DisplayMember = "Texto";
            cbotipomoneda.ValueMember = "Valor";
            cbotipomoneda.SelectedIndex = 0;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngenerarcuotas_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Clear();

            int cociente = 0;
            int residuo = 0;
            decimal monto_interes = 0;
            decimal montoprestamo = Convert.ToDecimal(txtmontoprestamo.Value.ToString());
            int porcentaje_interes = Convert.ToInt32(txtinteres.Value.ToString());
            int nrocuotas = Convert.ToInt32(txtnrocuotas.Value.ToString());
            monto_interes = (montoprestamo * porcentaje_interes) / 100;
            montoprestamo += monto_interes;
            cociente = Convert.ToInt32((Math.Truncate(montoprestamo / nrocuotas)).ToString());
            residuo = Convert.ToInt32((montoprestamo % nrocuotas).ToString());


            DateTime fechaInicio;
            TipoPago oTipoPago = listaPago.Where(tp =>
            tp.IdTipoPago== Convert.ToInt32(((OpcionCombo)cbotipopago.SelectedItem).Valor.ToString())).FirstOrDefault();
            fechaInicio = Convert.ToDateTime(txtfechainicio.Text);
            DateTime fechacuotapago = fechaInicio;

            fechacuotapago = fechacuotapago.AddDays(-1);
            ListaCuota = new List<Cuota>();
            if (oTipoPago.AplicaDias == 1)
            {
                fechacuotapago = fechacuotapago.AddDays(-1);
                for (int i = 1; i <= nrocuotas; i++)
                {
                    fechacuotapago = fechacuotapago.AddDays(oTipoPago.Valor);

                    ListaCuota.Add(new Cuota()
                    {
                        NumeroCuota = i,
                        FechaPagoCuota = fechacuotapago.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                        MontoCuota = i == 1 ? (cociente + residuo) : cociente,
                        EstadoCuota = "PENDIENTE",
                        ProximoPago = i == 1 ? 1 : 0
                    });
                }
            }
            else
            {
                for (int i = 1; i <= nrocuotas; i++)
                {
                    fechacuotapago = fechacuotapago.AddMonths(oTipoPago.Valor);
                    ListaCuota.Add(new Cuota()
                    {
                        NumeroCuota = i,
                        FechaPagoCuota = fechacuotapago.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                        MontoCuota = i == 1 ? (cociente + residuo) : cociente,
                        EstadoCuota = "PENDIENTE",
                        ProximoPago = i == 1 ? 1 : 0
                    });
                }
            }
            txtmontocuota.Text = cociente.ToString("0.00");
            txttotalinteres.Text = monto_interes.ToString("0.00");
            txtmontototalpagar.Text = montoprestamo.ToString("0.00");
            foreach (Cuota c in ListaCuota) {
                dgvdata.Rows.Add(new object[] {c.NumeroCuota,
                    Convert.ToDateTime(c.FechaPagoCuota,new CultureInfo("en-US")).ToString("dd/MM/yyyy"),
                    c.MontoCuota.ToString("0.00") });
            }

        }

        private void txtmontoprestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtinteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtnrocuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtnumerooperacion.Text == "")
            {
                MessageBox.Show("No se pudo generar un número de operación.\nFavor vuelva a intentarlo luego", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtclientenombre.Text.Trim() == "" || txtclientetipodocumento.Text.Trim() == "" || txtclientedocumento.Text.Trim() == "" )
            {
                MessageBox.Show("Debe ingresar los campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1) {
                MessageBox.Show("Debe generar las cuotas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Prestamo obj = new Prestamo()
            {
                NumeroOperacion = txtnumerooperacion.Text,
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                oTipoPago = new TipoPago() { IdTipoPago = Convert.ToInt32(((OpcionCombo)cbotipopago.SelectedItem).Valor.ToString()) },
                oTipoMoneda = new TipoMoneda() { IdTipoMoneda = Convert.ToInt32(((OpcionCombo)cbotipomoneda.SelectedItem).Valor.ToString()) },
                FechaInicio = Convert.ToDateTime(txtfechainicio.Text).ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                FechaFin = Convert.ToDateTime(dgvdata.Rows[dgvdata.Rows.Count - 1].Cells["FechaPago"].Value.ToString()).ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                MontoPrestamo = txtmontoprestamo.Value.ToString("0.00"),
                Interes = txtinteres.Value.ToString(),
                NumeroCuotas = Convert.ToInt32(txtnrocuotas.Value.ToString()),
                MontoCuota = txtmontocuota.Text,
                TotalIntereses = txttotalinteres.Text,
                MontoTotal = txtmontototalpagar.Text,
                NombreCliente = txtclientenombre.Text,
                TipoDocumento = txtclientetipodocumento.Text,
                NumeroDocumento = txtclientedocumento.Text,
                Direccion = txtclientedireccion.Text,
                Ciudad = txtclienteciudad.Text,
                Correo = txtclientecorreo.Text,
                NumeroTelefono = txtclientetelefono.Text,
                Estado = "EN CURSO",
                Clausula = clausulas
            };

            string mensaje = string.Empty;
            int operacionesRealizadas = PrestamoLogica.Instancia.Registrar(obj, ListaCuota, out mensaje);

            if (operacionesRealizadas > 0)
            {
                MessageBox.Show(string.Format("Registro Exitoso!.\nNúmero de operación generado: \"{0}\".\n\nEn la opción de \"Historial Préstamo\" podrá ver todo el detalle.", txtnumerooperacion.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void Limpiar()
        {
            string mensaje = string.Empty;


            txtnumerooperacion.Text = "";
            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtclientenombre.Text = "";
            txtclientetipodocumento.Text = "";
            txtclientedocumento.Text = "";
            txtclientetelefono.Text = "";
            txtclientedireccion.Text = "";
            txtclientecorreo.Text = "";
            txtclienteciudad.Text = "";

            txtmontoprestamo.Value = 1;
            txtinteres.Value = 0;
            txtnrocuotas.Value = 1;

            cbotipopago.SelectedIndex = 0;
            cbotipomoneda.SelectedIndex = 0;
            txtfechainicio.Value = DateTime.Now;

            txtmontocuota.Text = "";
            txttotalinteres.Text = "";
            txtmontototalpagar.Text = "";
            clausulas = "";
            dgvdata.Rows.Clear();
            ListaCuota = new List<Cuota>();
            int idcorrelativo = PrestamoLogica.Instancia.ObtenerCorrelativo(out mensaje);

            if (idcorrelativo < 1)
            {

                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                txtnumerooperacion.Text = String.Format("{0:000000}", idcorrelativo);
        }

        private void btnclausulas_Click(object sender, EventArgs e)
        {
            using (var form = new mdClausulas())
            {
                form.Clausulas = clausulas;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    clausulas = form.Clausulas;
                }
            }
        }

        private void btnbuscarinmuebles_Click(object sender, EventArgs e)
        {
            using (var form = new mdClientes())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtclientenombre.Text = form._nombrecompleto;
                    txtclientetipodocumento.Text = form._tipodocumento;
                    txtclientedocumento.Text = form._nrodocumento;
                    txtclientedireccion.Text = form._direccion;
                    txtclienteciudad.Text = form._ciudad;
                    txtclientecorreo.Text = form._correo;
                    txtclientetelefono.Text = form._telefono;
                }
            }
        }
    }
}
