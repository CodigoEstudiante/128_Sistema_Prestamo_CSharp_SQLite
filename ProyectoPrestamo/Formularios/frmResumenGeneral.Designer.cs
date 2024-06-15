namespace ProyectoPrestamo.Formularios
{
    partial class frmResumenGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenGeneral));
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.NroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIntereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NTelefonoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnborrarbusqueda = new FontAwesome.Sharp.IconButton();
            this.btnbusqueda = new FontAwesome.Sharp.IconButton();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.btnborrarfiltro = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvolver.ForeColor = System.Drawing.Color.Black;
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnvolver.IconColor = System.Drawing.Color.Black;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 19;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnvolver.Location = new System.Drawing.Point(977, 92);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(128, 26);
            this.btnvolver.TabIndex = 97;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1112, 52);
            this.label2.TabIndex = 96;
            this.label2.Text = "Resumen General";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 411);
            this.label1.TabIndex = 95;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOperacion,
            this.Estado,
            this.FechaRegistro,
            this.Formapago,
            this.TipoMoneda,
            this.FechaInicio,
            this.MontoPrestamo,
            this.Intereses,
            this.NroCuotas,
            this.MontoCuota,
            this.TotalIntereses,
            this.MontoTotal,
            this.NombreCliente,
            this.TipoDocumento,
            this.NroDocumento,
            this.Direccion,
            this.Ciudad,
            this.Correo,
            this.NTelefonoCelular});
            this.dgvdata.Location = new System.Drawing.Point(28, 171);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(1077, 287);
            this.dgvdata.TabIndex = 98;
            // 
            // NroOperacion
            // 
            this.NroOperacion.HeaderText = "Nº Operación";
            this.NroOperacion.Name = "NroOperacion";
            this.NroOperacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // Formapago
            // 
            this.Formapago.HeaderText = "Forma de pago";
            this.Formapago.Name = "Formapago";
            this.Formapago.ReadOnly = true;
            // 
            // TipoMoneda
            // 
            this.TipoMoneda.HeaderText = "Tipo Moneda";
            this.TipoMoneda.Name = "TipoMoneda";
            this.TipoMoneda.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // MontoPrestamo
            // 
            this.MontoPrestamo.HeaderText = "Monto Prestamo";
            this.MontoPrestamo.Name = "MontoPrestamo";
            this.MontoPrestamo.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.HeaderText = "Intereses %";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // NroCuotas
            // 
            this.NroCuotas.HeaderText = "Nº Cuotas";
            this.NroCuotas.Name = "NroCuotas";
            this.NroCuotas.ReadOnly = true;
            // 
            // MontoCuota
            // 
            this.MontoCuota.HeaderText = "Monto por Cuota";
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.ReadOnly = true;
            // 
            // TotalIntereses
            // 
            this.TotalIntereses.HeaderText = "Total Intereses";
            this.TotalIntereses.Name = "TotalIntereses";
            this.TotalIntereses.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 110;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "Nº Documento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // NTelefonoCelular
            // 
            this.NTelefonoCelular.HeaderText = "N° Telefono / Celular";
            this.NTelefonoCelular.Name = "NTelefonoCelular";
            this.NTelefonoCelular.ReadOnly = true;
            // 
            // btnborrarbusqueda
            // 
            this.btnborrarbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarbusqueda.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrarbusqueda.IconColor = System.Drawing.Color.Black;
            this.btnborrarbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrarbusqueda.IconSize = 17;
            this.btnborrarbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarbusqueda.Location = new System.Drawing.Point(1068, 139);
            this.btnborrarbusqueda.Name = "btnborrarbusqueda";
            this.btnborrarbusqueda.Size = new System.Drawing.Size(37, 21);
            this.btnborrarbusqueda.TabIndex = 104;
            this.btnborrarbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrarbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrarbusqueda.UseVisualStyleBackColor = true;
            this.btnborrarbusqueda.Click += new System.EventHandler(this.btnborrarbusqueda_Click);
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbusqueda.IconColor = System.Drawing.Color.Black;
            this.btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbusqueda.IconSize = 17;
            this.btnbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbusqueda.Location = new System.Drawing.Point(1027, 139);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(37, 21);
            this.btnbusqueda.TabIndex = 103;
            this.btnbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // cbobuscar
            // 
            this.cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Location = new System.Drawing.Point(735, 139);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(145, 21);
            this.cbobuscar.TabIndex = 101;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(886, 139);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(135, 21);
            this.txtbuscar.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(660, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 100;
            this.label12.Text = "Buscar por:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(28, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1077, 10);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(28, 98);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Fecha Inicio:";
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(148, 98);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(97, 20);
            this.txtfechafin.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Fecha Fin:";
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 17;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(261, 98);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(37, 20);
            this.iconButton3.TabIndex = 111;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnexportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportarexcel.IconColor = System.Drawing.Color.White;
            this.btnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportarexcel.IconSize = 17;
            this.btnexportarexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportarexcel.Location = new System.Drawing.Point(28, 140);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(37, 21);
            this.btnexportarexcel.TabIndex = 112;
            this.btnexportarexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = false;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // btnborrarfiltro
            // 
            this.btnborrarfiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarfiltro.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrarfiltro.IconColor = System.Drawing.Color.Black;
            this.btnborrarfiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrarfiltro.IconSize = 17;
            this.btnborrarfiltro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarfiltro.Location = new System.Drawing.Point(304, 98);
            this.btnborrarfiltro.Name = "btnborrarfiltro";
            this.btnborrarfiltro.Size = new System.Drawing.Size(37, 21);
            this.btnborrarfiltro.TabIndex = 113;
            this.btnborrarfiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrarfiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrarfiltro.UseVisualStyleBackColor = true;
            this.btnborrarfiltro.Click += new System.EventHandler(this.btnborrarfiltro_Click);
            // 
            // frmResumenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 486);
            this.Controls.Add(this.btnborrarfiltro);
            this.Controls.Add(this.btnexportarexcel);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnborrarbusqueda);
            this.Controls.Add(this.btnbusqueda);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResumenGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmResumenGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnvolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnborrarbusqueda;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnexportarexcel;
        private FontAwesome.Sharp.IconButton btnborrarfiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formapago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIntereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NTelefonoCelular;
    }
}