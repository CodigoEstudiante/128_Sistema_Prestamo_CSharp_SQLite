namespace ProyectoPrestamo.Formularios
{
    partial class frmRegistrarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarinmuebles = new FontAwesome.Sharp.IconButton();
            this.txtclientedireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtclientecorreo = new System.Windows.Forms.TextBox();
            this.txtclienteciudad = new System.Windows.Forms.TextBox();
            this.txtclientetelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtclientedocumento = new System.Windows.Forms.TextBox();
            this.txtclientetipodocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclientenombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnclausulas = new FontAwesome.Sharp.IconButton();
            this.txtmontoprestamo = new System.Windows.Forms.NumericUpDown();
            this.txtmontototalpagar = new System.Windows.Forms.TextBox();
            this.txttotalinteres = new System.Windows.Forms.TextBox();
            this.txtmontocuota = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.NumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngenerarcuotas = new FontAwesome.Sharp.IconButton();
            this.cbotipomoneda = new System.Windows.Forms.ComboBox();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.cbotipopago = new System.Windows.Forms.ComboBox();
            this.txtnrocuotas = new System.Windows.Forms.NumericUpDown();
            this.txtinteres = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtfecharegistro = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtnumerooperacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmontoprestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnrocuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinteres)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnbuscarinmuebles);
            this.groupBox1.Controls.Add(this.txtclientedireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtclientecorreo);
            this.groupBox1.Controls.Add(this.txtclienteciudad);
            this.groupBox1.Controls.Add(this.txtclientetelefono);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtclientedocumento);
            this.groupBox1.Controls.Add(this.txtclientetipodocumento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtclientenombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // btnbuscarinmuebles
            // 
            this.btnbuscarinmuebles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarinmuebles.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarinmuebles.IconColor = System.Drawing.Color.Black;
            this.btnbuscarinmuebles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarinmuebles.IconSize = 19;
            this.btnbuscarinmuebles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarinmuebles.Location = new System.Drawing.Point(509, 38);
            this.btnbuscarinmuebles.Name = "btnbuscarinmuebles";
            this.btnbuscarinmuebles.Size = new System.Drawing.Size(51, 23);
            this.btnbuscarinmuebles.TabIndex = 8;
            this.btnbuscarinmuebles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarinmuebles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbuscarinmuebles.UseVisualStyleBackColor = true;
            this.btnbuscarinmuebles.Click += new System.EventHandler(this.btnbuscarinmuebles_Click);
            // 
            // txtclientedireccion
            // 
            this.txtclientedireccion.Location = new System.Drawing.Point(14, 86);
            this.txtclientedireccion.Name = "txtclientedireccion";
            this.txtclientedireccion.Size = new System.Drawing.Size(187, 20);
            this.txtclientedireccion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Dirección:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(455, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "(*)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(305, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "(*)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(101, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "(*)";
            // 
            // txtclientecorreo
            // 
            this.txtclientecorreo.Location = new System.Drawing.Point(357, 86);
            this.txtclientecorreo.Name = "txtclientecorreo";
            this.txtclientecorreo.Size = new System.Drawing.Size(132, 20);
            this.txtclientecorreo.TabIndex = 6;
            // 
            // txtclienteciudad
            // 
            this.txtclienteciudad.Location = new System.Drawing.Point(222, 86);
            this.txtclienteciudad.Name = "txtclienteciudad";
            this.txtclienteciudad.Size = new System.Drawing.Size(113, 20);
            this.txtclienteciudad.TabIndex = 5;
            // 
            // txtclientetelefono
            // 
            this.txtclientetelefono.Location = new System.Drawing.Point(509, 86);
            this.txtclientetelefono.Name = "txtclientetelefono";
            this.txtclientetelefono.Size = new System.Drawing.Size(142, 20);
            this.txtclientetelefono.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(219, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ciudad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(354, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo Electronico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(506, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Telefono / Celular:";
            // 
            // txtclientedocumento
            // 
            this.txtclientedocumento.Location = new System.Drawing.Point(357, 40);
            this.txtclientedocumento.Name = "txtclientedocumento";
            this.txtclientedocumento.Size = new System.Drawing.Size(132, 20);
            this.txtclientedocumento.TabIndex = 3;
            // 
            // txtclientetipodocumento
            // 
            this.txtclientetipodocumento.Location = new System.Drawing.Point(222, 40);
            this.txtclientetipodocumento.Name = "txtclientetipodocumento";
            this.txtclientetipodocumento.Size = new System.Drawing.Size(113, 20);
            this.txtclientetipodocumento.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(354, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(219, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Documento:";
            // 
            // txtclientenombre
            // 
            this.txtclientenombre.Location = new System.Drawing.Point(14, 40);
            this.txtclientenombre.Name = "txtclientenombre";
            this.txtclientenombre.Size = new System.Drawing.Size(187, 20);
            this.txtclientenombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre Completo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 553);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(703, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar Nuevo Préstamo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnclausulas);
            this.groupBox2.Controls.Add(this.txtmontoprestamo);
            this.groupBox2.Controls.Add(this.txtmontototalpagar);
            this.groupBox2.Controls.Add(this.txttotalinteres);
            this.groupBox2.Controls.Add(this.txtmontocuota);
            this.groupBox2.Controls.Add(this.dgvdata);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btngenerarcuotas);
            this.groupBox2.Controls.Add(this.cbotipomoneda);
            this.groupBox2.Controls.Add(this.txtfechainicio);
            this.groupBox2.Controls.Add(this.cbotipopago);
            this.groupBox2.Controls.Add(this.txtnrocuotas);
            this.groupBox2.Controls.Add(this.txtinteres);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(30, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 335);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMACIÓN DEL PRESTAMO";
            // 
            // btnclausulas
            // 
            this.btnclausulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclausulas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnclausulas.IconColor = System.Drawing.Color.Black;
            this.btnclausulas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclausulas.IconSize = 19;
            this.btnclausulas.Location = new System.Drawing.Point(420, 38);
            this.btnclausulas.Name = "btnclausulas";
            this.btnclausulas.Size = new System.Drawing.Size(105, 23);
            this.btnclausulas.TabIndex = 13;
            this.btnclausulas.Text = "Agregar Cláusulas";
            this.btnclausulas.UseVisualStyleBackColor = true;
            this.btnclausulas.Click += new System.EventHandler(this.btnclausulas_Click);
            // 
            // txtmontoprestamo
            // 
            this.txtmontoprestamo.Location = new System.Drawing.Point(14, 41);
            this.txtmontoprestamo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtmontoprestamo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtmontoprestamo.Name = "txtmontoprestamo";
            this.txtmontoprestamo.Size = new System.Drawing.Size(116, 20);
            this.txtmontoprestamo.TabIndex = 10;
            this.txtmontoprestamo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtmontoprestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontoprestamo_KeyPress);
            // 
            // txtmontototalpagar
            // 
            this.txtmontototalpagar.Location = new System.Drawing.Point(290, 148);
            this.txtmontototalpagar.Name = "txtmontototalpagar";
            this.txtmontototalpagar.ReadOnly = true;
            this.txtmontototalpagar.Size = new System.Drawing.Size(104, 20);
            this.txtmontototalpagar.TabIndex = 82;
            // 
            // txttotalinteres
            // 
            this.txttotalinteres.Location = new System.Drawing.Point(156, 148);
            this.txttotalinteres.Name = "txttotalinteres";
            this.txttotalinteres.ReadOnly = true;
            this.txttotalinteres.Size = new System.Drawing.Size(106, 20);
            this.txttotalinteres.TabIndex = 81;
            // 
            // txtmontocuota
            // 
            this.txtmontocuota.Location = new System.Drawing.Point(14, 148);
            this.txtmontocuota.Name = "txtmontocuota";
            this.txtmontocuota.ReadOnly = true;
            this.txtmontocuota.Size = new System.Drawing.Size(116, 20);
            this.txtmontocuota.TabIndex = 80;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
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
            this.NumeroCuota,
            this.FechaPago,
            this.MontoCuota});
            this.dgvdata.Location = new System.Drawing.Point(14, 180);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(511, 141);
            this.dgvdata.TabIndex = 18;
            // 
            // NumeroCuota
            // 
            this.NumeroCuota.HeaderText = "N° de Cuota";
            this.NumeroCuota.Name = "NumeroCuota";
            this.NumeroCuota.ReadOnly = true;
            this.NumeroCuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroCuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaPago.Width = 110;
            // 
            // MontoCuota
            // 
            this.MontoCuota.HeaderText = "Monto Cuota";
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.ReadOnly = true;
            this.MontoCuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MontoCuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MontoCuota.Width = 140;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(287, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 13);
            this.label25.TabIndex = 62;
            this.label25.Text = "Monto Total a Pagar:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(153, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "Total Intereses:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(11, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Monto por Cuota:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(14, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 10);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // btngenerarcuotas
            // 
            this.btngenerarcuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarcuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcuotas.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            this.btngenerarcuotas.IconColor = System.Drawing.Color.Black;
            this.btngenerarcuotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarcuotas.IconSize = 40;
            this.btngenerarcuotas.Location = new System.Drawing.Point(420, 69);
            this.btngenerarcuotas.Name = "btngenerarcuotas";
            this.btngenerarcuotas.Size = new System.Drawing.Size(105, 39);
            this.btngenerarcuotas.TabIndex = 17;
            this.btngenerarcuotas.Text = "Generar Cuotas";
            this.btngenerarcuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerarcuotas.UseVisualStyleBackColor = true;
            this.btngenerarcuotas.Click += new System.EventHandler(this.btngenerarcuotas_Click);
            // 
            // cbotipomoneda
            // 
            this.cbotipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomoneda.FormattingEnabled = true;
            this.cbotipomoneda.Location = new System.Drawing.Point(156, 84);
            this.cbotipomoneda.Name = "cbotipomoneda";
            this.cbotipomoneda.Size = new System.Drawing.Size(106, 21);
            this.cbotipomoneda.TabIndex = 15;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(290, 85);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 16;
            // 
            // cbotipopago
            // 
            this.cbotipopago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipopago.FormattingEnabled = true;
            this.cbotipopago.Location = new System.Drawing.Point(14, 84);
            this.cbotipopago.Name = "cbotipopago";
            this.cbotipopago.Size = new System.Drawing.Size(116, 21);
            this.cbotipopago.TabIndex = 14;
            // 
            // txtnrocuotas
            // 
            this.txtnrocuotas.Location = new System.Drawing.Point(290, 41);
            this.txtnrocuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnrocuotas.Name = "txtnrocuotas";
            this.txtnrocuotas.Size = new System.Drawing.Size(97, 20);
            this.txtnrocuotas.TabIndex = 12;
            this.txtnrocuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnrocuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnrocuotas_KeyPress);
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(156, 41);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(106, 20);
            this.txtinteres.TabIndex = 11;
            this.txtinteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinteres_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(188, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fecha Inicio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(344, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "(*)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(201, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "(*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(96, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "(*)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(153, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tipo Moneda:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Forma de Pago:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(287, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "N° Cuotas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(153, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Interes     :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(11, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Monto Prestamo:";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(585, 405);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(106, 83);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "Registrar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnvolver.IconColor = System.Drawing.Color.Black;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 50;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnvolver.Location = new System.Drawing.Point(585, 509);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(106, 83);
            this.btnvolver.TabIndex = 20;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.txtfecharegistro);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txtnumerooperacion);
            this.groupBox4.Location = new System.Drawing.Point(30, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 49);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // txtfecharegistro
            // 
            this.txtfecharegistro.Location = new System.Drawing.Point(284, 19);
            this.txtfecharegistro.Name = "txtfecharegistro";
            this.txtfecharegistro.ReadOnly = true;
            this.txtfecharegistro.Size = new System.Drawing.Size(100, 20);
            this.txtfecharegistro.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Nº Operación:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(201, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Fecha registro:";
            // 
            // txtnumerooperacion
            // 
            this.txtnumerooperacion.Location = new System.Drawing.Point(86, 19);
            this.txtnumerooperacion.Name = "txtnumerooperacion";
            this.txtnumerooperacion.ReadOnly = true;
            this.txtnumerooperacion.Size = new System.Drawing.Size(100, 20);
            this.txtnumerooperacion.TabIndex = 0;
            // 
            // frmRegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRegistrarPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmontoprestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnrocuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinteres)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtclientecorreo;
        private System.Windows.Forms.TextBox txtclienteciudad;
        private System.Windows.Forms.TextBox txtclientetelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtclientedocumento;
        private System.Windows.Forms.TextBox txtclientetipodocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtclientenombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclientedireccion;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarinmuebles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotipomoneda;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.ComboBox cbotipopago;
        private System.Windows.Forms.NumericUpDown txtnrocuotas;
        private System.Windows.Forms.NumericUpDown txtinteres;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btngenerarcuotas;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtmontototalpagar;
        private System.Windows.Forms.TextBox txttotalinteres;
        private System.Windows.Forms.TextBox txtmontocuota;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnvolver;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtfecharegistro;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtnumerooperacion;
        private System.Windows.Forms.NumericUpDown txtmontoprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private FontAwesome.Sharp.IconButton btnclausulas;
    }
}