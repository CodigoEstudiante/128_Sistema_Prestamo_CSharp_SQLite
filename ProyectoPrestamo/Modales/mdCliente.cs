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

namespace ProyectoPrestamo.Modales
{
    public partial class mdCliente : Form
    {
        public Clientes oCliente { get; set; }
        public bool Editar { get; set; }
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            if (oCliente != null) {
                txtclientenombre.Text = oCliente.NombreCompleto;
                txtclientetipodocumento.Text = oCliente.TipoDocumento;
                txtclientedocumento.Text = oCliente.NumeroDocumento;
                txtclientedireccion.Text = oCliente.Direccion;
                txtclienteciudad.Text = oCliente.Ciudad;
                txtclientecorreo.Text = oCliente.Correo;
                txtclientetelefono.Text = oCliente.NumeroTelefono;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (txtclientenombre.Text.Trim() == "" || txtclientetipodocumento.Text.Trim() == "" || txtclientedocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar los campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Editar)
            {
                int _idtemp = oCliente.IdCliente;
                int nroperacion = ClienteLogica.Instancia.Editar(new Clientes()
                {
                    IdCliente = _idtemp,
                    NombreCompleto = txtclientenombre.Text,
                    TipoDocumento = txtclientetipodocumento.Text,
                    NumeroDocumento = txtclientedocumento.Text,
                    Direccion = txtclientedireccion.Text,
                    Ciudad = txtclienteciudad.Text,
                    Correo = txtclientecorreo.Text,
                    NumeroTelefono = txtclientetelefono.Text
                }, out mensaje);
                if (nroperacion < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    oCliente = new Clientes()
                    {
                        IdCliente = _idtemp,
                        NombreCompleto = txtclientenombre.Text,
                        TipoDocumento = txtclientetipodocumento.Text,
                        NumeroDocumento = txtclientedocumento.Text,
                        Direccion = txtclientedireccion.Text,
                        Ciudad = txtclienteciudad.Text,
                        Correo = txtclientecorreo.Text,
                        NumeroTelefono = txtclientetelefono.Text,
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
            else {
                int idgenerado = ClienteLogica.Instancia.Registrar(new Clientes() {
                    NombreCompleto = txtclientenombre.Text,
                    TipoDocumento = txtclientetipodocumento.Text,
                    NumeroDocumento = txtclientedocumento.Text,
                    Direccion = txtclientedireccion.Text,
                    Ciudad = txtclienteciudad.Text,
                    Correo = txtclientecorreo.Text,
                    NumeroTelefono = txtclientetelefono.Text
                }, out mensaje);

                if (idgenerado < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    oCliente = new Clientes()
                    {
                        IdCliente = idgenerado,
                        NombreCompleto = txtclientenombre.Text,
                        TipoDocumento = txtclientetipodocumento.Text,
                        NumeroDocumento = txtclientedocumento.Text,
                        Direccion = txtclientedireccion.Text,
                        Ciudad = txtclienteciudad.Text,
                        Correo = txtclientecorreo.Text,
                        NumeroTelefono = txtclientetelefono.Text,
                    };
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
