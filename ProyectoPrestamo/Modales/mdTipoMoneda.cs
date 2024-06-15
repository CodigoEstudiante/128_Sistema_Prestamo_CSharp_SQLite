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
    public partial class mdTipoMoneda : Form
    {
        public TipoMoneda oTipoMoneda { get; set; }
        public bool Editar { get; set; }
        public mdTipoMoneda()
        {
            InitializeComponent();
        }

        private void mdTipoMoneda_Load(object sender, EventArgs e)
        {
            if (oTipoMoneda != null)
            {
                txtdivisa.Text = oTipoMoneda.Divisa;
                txtabreviatura.Text = oTipoMoneda.Abreviatura;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (txtdivisa.Text.Trim() == "" || txtabreviatura.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar los campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Editar)
            {
                int _idtemp = oTipoMoneda.IdTipoMoneda;

                int existe = TipoMonedaLogica.Instancia.Existe(txtdivisa.Text, _idtemp, out mensaje);
                if (existe > 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int nroperacion = TipoMonedaLogica.Instancia.Editar(new TipoMoneda()
                {
                    IdTipoMoneda = _idtemp,
                    Divisa = txtdivisa.Text,
                    Abreviatura = txtabreviatura.Text
                }, out mensaje);

                if (nroperacion < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    oTipoMoneda = new TipoMoneda()
                    {
                        IdTipoMoneda = _idtemp,
                        Divisa = txtdivisa.Text,
                        Abreviatura = txtabreviatura.Text
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
            else
            {
                int existe = TipoMonedaLogica.Instancia.Existe(txtdivisa.Text,0, out mensaje);
                if (existe > 0) {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                int idgenerado = TipoMonedaLogica.Instancia.Guardar(new TipoMoneda()
                {
                    Divisa = txtdivisa.Text,
                    Abreviatura = txtabreviatura.Text
                }, out mensaje);

                if (idgenerado < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    oTipoMoneda = new TipoMoneda()
                    {
                        IdTipoMoneda = idgenerado,
                        Divisa = txtdivisa.Text,
                        Abreviatura = txtabreviatura.Text
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
