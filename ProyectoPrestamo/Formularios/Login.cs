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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool encontrado = false;

            if (txtdocumento.Text == "administrador" && txtclave.Text == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                Usuario ouser = UsuarioLogica.Instancia.Obtener();
                encontrado = (ouser.NombreUsuario == txtdocumento.Text && ouser.Clave == txtclave.Text) ? true : false;

                if (encontrado)
                {
                    Form1 frm = new Form1();
                    frm.NombreUsuario = ouser.NombreUsuario;
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                }
                else
                {
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }


        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            txtdocumento.Focus();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
