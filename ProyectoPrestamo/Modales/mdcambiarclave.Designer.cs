namespace ProyectoPrestamo.Modales
{
    partial class mdcambiarclave
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
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnaceptar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirmarnuevaclave = new System.Windows.Forms.TextBox();
            this.txtnuevaclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclaveactual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncancelar.IconSize = 20;
            this.btncancelar.Location = new System.Drawing.Point(140, 202);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 23);
            this.btncancelar.TabIndex = 114;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaceptar.ForeColor = System.Drawing.Color.Black;
            this.btnaceptar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnaceptar.IconColor = System.Drawing.Color.Black;
            this.btnaceptar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnaceptar.IconSize = 20;
            this.btnaceptar.Location = new System.Drawing.Point(7, 202);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(94, 23);
            this.btnaceptar.TabIndex = 113;
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(227, 47);
            this.label2.TabIndex = 112;
            this.label2.Text = "Cambiar Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 142);
            this.label3.TabIndex = 111;
            // 
            // txtconfirmarnuevaclave
            // 
            this.txtconfirmarnuevaclave.Location = new System.Drawing.Point(20, 165);
            this.txtconfirmarnuevaclave.Name = "txtconfirmarnuevaclave";
            this.txtconfirmarnuevaclave.PasswordChar = '*';
            this.txtconfirmarnuevaclave.Size = new System.Drawing.Size(204, 20);
            this.txtconfirmarnuevaclave.TabIndex = 120;
            // 
            // txtnuevaclave
            // 
            this.txtnuevaclave.Location = new System.Drawing.Point(20, 123);
            this.txtnuevaclave.Name = "txtnuevaclave";
            this.txtnuevaclave.PasswordChar = '*';
            this.txtnuevaclave.Size = new System.Drawing.Size(204, 20);
            this.txtnuevaclave.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Confirmar Nueva Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // txtclaveactual
            // 
            this.txtclaveactual.Location = new System.Drawing.Point(20, 81);
            this.txtclaveactual.Name = "txtclaveactual";
            this.txtclaveactual.PasswordChar = '*';
            this.txtclaveactual.Size = new System.Drawing.Size(204, 20);
            this.txtclaveactual.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Contraseña Actual:";
            // 
            // mdcambiarclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 234);
            this.Controls.Add(this.txtconfirmarnuevaclave);
            this.Controls.Add(this.txtnuevaclave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtclaveactual);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mdcambiarclave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.mdcambiarclave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnaceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfirmarnuevaclave;
        private System.Windows.Forms.TextBox txtnuevaclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtclaveactual;
        private System.Windows.Forms.Label label10;
    }
}