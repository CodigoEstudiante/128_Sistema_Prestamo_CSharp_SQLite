namespace ProyectoPrestamo.Formularios
{
    partial class frmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmisdatos = new FontAwesome.Sharp.IconButton();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btntipomoneda = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(630, 52);
            this.label2.TabIndex = 92;
            this.label2.Text = "Configuración";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 517);
            this.label1.TabIndex = 91;
            // 
            // btnmisdatos
            // 
            this.btnmisdatos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnmisdatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmisdatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmisdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmisdatos.ForeColor = System.Drawing.Color.White;
            this.btnmisdatos.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnmisdatos.IconColor = System.Drawing.Color.White;
            this.btnmisdatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmisdatos.IconSize = 30;
            this.btnmisdatos.Location = new System.Drawing.Point(24, 79);
            this.btnmisdatos.Name = "btnmisdatos";
            this.btnmisdatos.Size = new System.Drawing.Size(103, 48);
            this.btnmisdatos.TabIndex = 95;
            this.btnmisdatos.Text = "Mis Datos";
            this.btnmisdatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmisdatos.UseVisualStyleBackColor = false;
            this.btnmisdatos.Click += new System.EventHandler(this.btnmisdatos_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(24, 126);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbltitulo.Size = new System.Drawing.Size(600, 38);
            this.lbltitulo.TabIndex = 96;
            this.lbltitulo.Text = "Mis Datos";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contenedor
            // 
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Location = new System.Drawing.Point(24, 163);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(600, 387);
            this.contenedor.TabIndex = 97;
            // 
            // btntipomoneda
            // 
            this.btntipomoneda.BackColor = System.Drawing.Color.White;
            this.btntipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntipomoneda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntipomoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipomoneda.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btntipomoneda.IconColor = System.Drawing.Color.Black;
            this.btntipomoneda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntipomoneda.IconSize = 30;
            this.btntipomoneda.Location = new System.Drawing.Point(126, 79);
            this.btntipomoneda.Name = "btntipomoneda";
            this.btntipomoneda.Size = new System.Drawing.Size(103, 48);
            this.btntipomoneda.TabIndex = 95;
            this.btntipomoneda.Text = "Tipo Moneda";
            this.btntipomoneda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntipomoneda.UseVisualStyleBackColor = false;
            this.btntipomoneda.Click += new System.EventHandler(this.btntipomoneda_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnvolver.IconColor = System.Drawing.Color.Black;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 30;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnvolver.Location = new System.Drawing.Point(521, 79);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 40);
            this.btnvolver.TabIndex = 98;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 617);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btntipomoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmisdatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnmisdatos;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton btntipomoneda;
        private FontAwesome.Sharp.IconButton btnvolver;
    }
}