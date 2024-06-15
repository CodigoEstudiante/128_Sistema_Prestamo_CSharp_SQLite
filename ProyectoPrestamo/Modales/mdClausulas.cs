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
    public partial class mdClausulas : Form
    {
        public string Clausulas { get; set; }
        public mdClausulas()
        {
            InitializeComponent();
        }

        private void mdClausulas_Load(object sender, EventArgs e)
        {
            txtclausulas.Focus();
            txtclausulas.Text = this.Clausulas;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.Clausulas = txtclausulas.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
