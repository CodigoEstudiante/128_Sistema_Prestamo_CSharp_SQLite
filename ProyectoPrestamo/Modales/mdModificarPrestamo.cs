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

namespace ProyectoPrestamo.Formularios
{
    public partial class mdModificarPrestamo : Form
    {

        public string _nombrecompleto { get; set; }
        public string _tipodocumento { get; set; }
        public string _nrodocumento { get; set; }
        public string _direccion { get; set; }
        public string _ciudad { get; set; }
        public string _correo { get; set; }
        public string _telefono { get; set; }
        public string _clausulas { get; set; }
        public int _idprestamo { get; set; }

        public mdModificarPrestamo()
        {
            InitializeComponent();
        }

        private void mdModificarPrestamo_Load(object sender, EventArgs e)
        {
            txtclientenombre.Text = _nombrecompleto;
            txtclientetipodocumento.Text = _tipodocumento;
            txtclientedocumento.Text = _nrodocumento;
            txtclientedireccion.Text = _direccion;
            txtclienteciudad.Text = _ciudad;
            txtclientecorreo.Text = _correo;
            txtclientetelefono.Text = _telefono;
            txtclausulas.Text = _clausulas;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtclientenombre.Text.Trim() == "" || txtclientetipodocumento.Text.Trim() == "" || txtclientedocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar los campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int nrooperaciones = PrestamoLogica.Instancia.Actualizar(new Prestamo() {
                IdPrestamo = _idprestamo,
                NombreCliente = txtclientenombre.Text,
                TipoDocumento = txtclientetipodocumento.Text,
                NumeroDocumento = txtclientedocumento.Text,
                Direccion = txtclientedireccion.Text,
                Ciudad = txtclienteciudad.Text,
                Correo = txtclientecorreo.Text,
                NumeroTelefono = txtclientetelefono.Text,
                Clausula = txtclausulas.Text
            },out mensaje);



            if (nrooperaciones < 1)
            {
                MessageBox.Show(mensaje,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _nombrecompleto = txtclientenombre.Text;
                _tipodocumento = txtclientetipodocumento.Text;
                _nrodocumento = txtclientedocumento.Text;
                _direccion = txtclientedireccion.Text;
                _ciudad = txtclienteciudad.Text ;
                _correo = txtclientecorreo.Text ;
                _telefono = txtclientetelefono.Text;
                _clausulas = txtclausulas.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
