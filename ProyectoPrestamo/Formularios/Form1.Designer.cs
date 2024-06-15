namespace ProyectoPrestamo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrarprestamo = new FontAwesome.Sharp.IconButton();
            this.btnregistrarcobro = new FontAwesome.Sharp.IconButton();
            this.btnclientes = new FontAwesome.Sharp.IconButton();
            this.btnconfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnhistorialprestamo = new FontAwesome.Sharp.IconButton();
            this.btnresumengeneral = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.lblusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(760, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "CE PRESTAMO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnregistrarprestamo
            // 
            this.btnregistrarprestamo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnregistrarprestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarprestamo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnregistrarprestamo.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnregistrarprestamo.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnregistrarprestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrarprestamo.IconSize = 100;
            this.btnregistrarprestamo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregistrarprestamo.Location = new System.Drawing.Point(109, 165);
            this.btnregistrarprestamo.Name = "btnregistrarprestamo";
            this.btnregistrarprestamo.Size = new System.Drawing.Size(143, 134);
            this.btnregistrarprestamo.TabIndex = 1;
            this.btnregistrarprestamo.Text = "Registrar Préstamo";
            this.btnregistrarprestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregistrarprestamo.UseVisualStyleBackColor = false;
            this.btnregistrarprestamo.Click += new System.EventHandler(this.btnregistrarprestamo_Click);
            // 
            // btnregistrarcobro
            // 
            this.btnregistrarcobro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnregistrarcobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarcobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarcobro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnregistrarcobro.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnregistrarcobro.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnregistrarcobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrarcobro.IconSize = 100;
            this.btnregistrarcobro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregistrarcobro.Location = new System.Drawing.Point(308, 165);
            this.btnregistrarcobro.Name = "btnregistrarcobro";
            this.btnregistrarcobro.Size = new System.Drawing.Size(143, 134);
            this.btnregistrarcobro.TabIndex = 2;
            this.btnregistrarcobro.Text = "Registrar Cobro";
            this.btnregistrarcobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregistrarcobro.UseVisualStyleBackColor = false;
            this.btnregistrarcobro.Click += new System.EventHandler(this.btnregistrarcobro_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnclientes.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclientes.IconSize = 100;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclientes.Location = new System.Drawing.Point(109, 343);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(143, 134);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnconfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguracion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnconfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnconfiguracion.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnconfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnconfiguracion.IconSize = 100;
            this.btnconfiguracion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnconfiguracion.Location = new System.Drawing.Point(509, 343);
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Size = new System.Drawing.Size(143, 134);
            this.btnconfiguracion.TabIndex = 4;
            this.btnconfiguracion.Text = "Configuración";
            this.btnconfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnconfiguracion.UseVisualStyleBackColor = false;
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
            // 
            // btnhistorialprestamo
            // 
            this.btnhistorialprestamo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnhistorialprestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistorialprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistorialprestamo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnhistorialprestamo.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.btnhistorialprestamo.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnhistorialprestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhistorialprestamo.IconSize = 100;
            this.btnhistorialprestamo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhistorialprestamo.Location = new System.Drawing.Point(509, 165);
            this.btnhistorialprestamo.Name = "btnhistorialprestamo";
            this.btnhistorialprestamo.Size = new System.Drawing.Size(143, 134);
            this.btnhistorialprestamo.TabIndex = 5;
            this.btnhistorialprestamo.Text = "Historial Préstamo";
            this.btnhistorialprestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhistorialprestamo.UseVisualStyleBackColor = false;
            this.btnhistorialprestamo.Click += new System.EventHandler(this.btnhistorialprestamo_Click);
            // 
            // btnresumengeneral
            // 
            this.btnresumengeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnresumengeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresumengeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresumengeneral.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnresumengeneral.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnresumengeneral.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnresumengeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnresumengeneral.IconSize = 100;
            this.btnresumengeneral.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnresumengeneral.Location = new System.Drawing.Point(308, 343);
            this.btnresumengeneral.Name = "btnresumengeneral";
            this.btnresumengeneral.Size = new System.Drawing.Size(143, 134);
            this.btnresumengeneral.TabIndex = 6;
            this.btnresumengeneral.Text = "Resumen General";
            this.btnresumengeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnresumengeneral.UseVisualStyleBackColor = false;
            this.btnresumengeneral.Click += new System.EventHandler(this.btnresumengeneral_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(686, 14);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(62, 64);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfo.Location = new System.Drawing.Point(608, 14);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(62, 64);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.LightGray;
            this.lblusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblusuario.Location = new System.Drawing.Point(0, 93);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblusuario.Size = new System.Drawing.Size(760, 32);
            this.lblusuario.TabIndex = 9;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 521);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnresumengeneral);
            this.Controls.Add(this.btnhistorialprestamo);
            this.Controls.Add(this.btnconfiguracion);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.btnregistrarcobro);
            this.Controls.Add(this.btnregistrarprestamo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(776, 560);
            this.MinimumSize = new System.Drawing.Size(776, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnregistrarprestamo;
        private FontAwesome.Sharp.IconButton btnregistrarcobro;
        private FontAwesome.Sharp.IconButton btnclientes;
        private FontAwesome.Sharp.IconButton btnconfiguracion;
        private FontAwesome.Sharp.IconButton btnhistorialprestamo;
        private FontAwesome.Sharp.IconButton btnresumengeneral;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnInfo;
        private System.Windows.Forms.Label lblusuario;
    }
}

