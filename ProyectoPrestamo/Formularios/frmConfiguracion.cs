using FontAwesome.Sharp;
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
    public partial class frmConfiguracion : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        private static Form formularioPadre;
        public frmConfiguracion(Form _formulariopadre)
        {
            formularioPadre = _formulariopadre;
            InitializeComponent();
        }



        private void AbrirFormulario(IconButton menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
                MenuActivo.IconColor = Color.Black;
                MenuActivo.ForeColor = Color.Black;
            }
            menu.BackColor = Color.SteelBlue;
            menu.IconColor = Color.White;
            menu.ForeColor = Color.White;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            lbltitulo.Text = formulario.Tag.ToString();
            formulario.Show();


        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            AbrirFormulario(btnmisdatos, new frmMisDatos(formularioPadre,this));
        }

        private void btnmisdatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnmisdatos, new frmMisDatos(formularioPadre,this));
        }

        private void btntipomoneda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btntipomoneda, new frmTipoMoneda());
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
