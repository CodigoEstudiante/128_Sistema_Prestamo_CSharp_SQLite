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
    public partial class frmMisDatos : Form
    {
        private static Form formularioPadre;
        private static Form formularioPadreSub;
        private static Usuario user = new Usuario();
        public frmMisDatos(Form _formulariopadre,Form _formulariopadresub)
        {
            formularioPadre = _formulariopadre;
            formularioPadreSub = _formulariopadresub;
            InitializeComponent();
        }

        private void frmMisDatos_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
            if(obtenido)
                picLogo.Image = ByteToImage(byteimage);
            else
                MessageBox.Show("No se pudo cargar el logo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            Datos da = DatoLogica.Instancia.Obtener();
            user = UsuarioLogica.Instancia.Obtener();

            txtnombreusuario.Text = user.NombreUsuario;

            txtrazonsocial.Text = da.RazonSocial;
            txtruc.Text =  da.RUC;
            txtrepresentante.Text = da.Representante;
            txtcorreo.Text = da.Correo;
            txttelefono.Text = da.Telefono;
            txtciudad.Text = da.Ciudad;

        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            //configuracion de ventana para seleccionar un archivo
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                int numerooperacion = DatoLogica.Instancia.ActualizarLogo(byteImagen, out mensaje);

                if (numerooperacion < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    picLogo.Image = ByteToImage(byteImagen);
                }
            }
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int nrooperacion = DatoLogica.Instancia.Guardar(new Datos() {
                RazonSocial = txtrazonsocial.Text,
                RUC = txtruc.Text,
                Representante = txtrepresentante.Text,
                Correo = txtcorreo.Text,
                Ciudad = txtciudad.Text,
                Telefono = txttelefono.Text
            }, out mensaje);

            if (nrooperacion < 1)
            {
                MessageBox.Show("No se pudo guardar los cambios, intente más tarde", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnguardarsesion_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int nrooperacion = UsuarioLogica.Instancia.Guardar(new Usuario()
            {
                NombreUsuario = txtnombreusuario.Text
            }, out mensaje);

            if (nrooperacion < 1)
            {
                MessageBox.Show("No se pudo guardar los cambios, intente más tarde", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("El nombre de usuario fue modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncambiarclave_Click(object sender, EventArgs e)
        {
            using (var form = new mdcambiarclave())
            {
                form.clave = user.Clave;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    user.Clave = form.clave;
                    if (MessageBox.Show("La contraseña fue cambiada exitosamente.\nEs necesario cerrar sesión y volver a ingresar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        formularioPadreSub.Close();
                        formularioPadre.Close();
                    }
                }
            }
        }
    }
}
