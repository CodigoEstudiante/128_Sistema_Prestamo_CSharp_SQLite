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
    public partial class mdCancelarPrestamo : Form
    {
        private static Usuario oUsuario;
        public string _numeroOperacion { get; set; }
        public int _idprestamo { get; set; }
        public mdCancelarPrestamo()
        {
            InitializeComponent();
        }

        private void mdCancelarPrestamo_Load(object sender, EventArgs e)
        {
            oUsuario = UsuarioLogica.Instancia.Obtener();
            if (oUsuario.IdUsuario != 0)
            {
                lbltexto.Text = "El número de operación: \"" + _numeroOperacion + "\" será cancelado.\n\nPara continuar con la acción debe ingresar su contraseña y presionar \"Aceptar\"";
            }
            else
            {
                MessageBox.Show("No se pudo obtener los datos, vuelva a intentarlo más tarde", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtclaveactual.Text != oUsuario.Clave)
            {
                MessageBox.Show("La contraseña no es correcta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string mensaje = string.Empty;
                int respuesta = PrestamoLogica.Instancia.Cancelar(_idprestamo, out mensaje);
                if (respuesta < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
