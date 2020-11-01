namespace HackatonGrupo02
{
    partial class FormPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_tarjetas = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_movimientos = new FontAwesome.Sharp.IconButton();
            this.btn_rendimiento = new FontAwesome.Sharp.IconButton();
            this.btn_comparacion = new FontAwesome.Sharp.IconButton();
            this.btn_extraer = new FontAwesome.Sharp.IconButton();
            this.btn_transferir = new FontAwesome.Sharp.IconButton();
            this.btn_depositar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelCuentas = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.btn_tarjetas);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btn_movimientos);
            this.panelMenu.Controls.Add(this.btn_rendimiento);
            this.panelMenu.Controls.Add(this.btn_comparacion);
            this.panelMenu.Controls.Add(this.btn_extraer);
            this.panelMenu.Controls.Add(this.btn_transferir);
            this.panelMenu.Controls.Add(this.btn_depositar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 768);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconButton2.IconColor = System.Drawing.Color.Ivory;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 555);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(300, 60);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "SERVICIOS";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_tarjetas
            // 
            this.btn_tarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tarjetas.FlatAppearance.BorderSize = 0;
            this.btn_tarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tarjetas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_tarjetas.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tarjetas.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btn_tarjetas.IconColor = System.Drawing.Color.Ivory;
            this.btn_tarjetas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tarjetas.IconSize = 55;
            this.btn_tarjetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tarjetas.Location = new System.Drawing.Point(0, 495);
            this.btn_tarjetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tarjetas.Name = "btn_tarjetas";
            this.btn_tarjetas.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_tarjetas.Rotation = 0D;
            this.btn_tarjetas.Size = new System.Drawing.Size(300, 60);
            this.btn_tarjetas.TabIndex = 8;
            this.btn_tarjetas.Text = "TARJETAS";
            this.btn_tarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tarjetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tarjetas.UseVisualStyleBackColor = true;
            this.btn_tarjetas.Click += new System.EventHandler(this.btn_tarjetas_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.Ivory;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 55;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 708);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(300, 60);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "SALIR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_movimientos
            // 
            this.btn_movimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_movimientos.FlatAppearance.BorderSize = 0;
            this.btn_movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movimientos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_movimientos.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movimientos.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btn_movimientos.IconColor = System.Drawing.Color.Ivory;
            this.btn_movimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_movimientos.IconSize = 55;
            this.btn_movimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_movimientos.Location = new System.Drawing.Point(0, 435);
            this.btn_movimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_movimientos.Name = "btn_movimientos";
            this.btn_movimientos.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_movimientos.Rotation = 0D;
            this.btn_movimientos.Size = new System.Drawing.Size(300, 60);
            this.btn_movimientos.TabIndex = 6;
            this.btn_movimientos.Text = "MOVIMIENTOS";
            this.btn_movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_movimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_movimientos.UseVisualStyleBackColor = true;
            this.btn_movimientos.Click += new System.EventHandler(this.btn_movimientos_Click);
            // 
            // btn_rendimiento
            // 
            this.btn_rendimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rendimiento.FlatAppearance.BorderSize = 0;
            this.btn_rendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendimiento.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_rendimiento.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rendimiento.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_rendimiento.IconColor = System.Drawing.Color.Ivory;
            this.btn_rendimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rendimiento.IconSize = 55;
            this.btn_rendimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rendimiento.Location = new System.Drawing.Point(0, 375);
            this.btn_rendimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rendimiento.Name = "btn_rendimiento";
            this.btn_rendimiento.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_rendimiento.Rotation = 0D;
            this.btn_rendimiento.Size = new System.Drawing.Size(300, 60);
            this.btn_rendimiento.TabIndex = 5;
            this.btn_rendimiento.Text = "RENDIMIENTO";
            this.btn_rendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rendimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rendimiento.UseVisualStyleBackColor = true;
            this.btn_rendimiento.Click += new System.EventHandler(this.btn_rendimiento_Click);
            // 
            // btn_comparacion
            // 
            this.btn_comparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_comparacion.FlatAppearance.BorderSize = 0;
            this.btn_comparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comparacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_comparacion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comparacion.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_comparacion.IconColor = System.Drawing.Color.Ivory;
            this.btn_comparacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_comparacion.IconSize = 55;
            this.btn_comparacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comparacion.Location = new System.Drawing.Point(0, 315);
            this.btn_comparacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_comparacion.Name = "btn_comparacion";
            this.btn_comparacion.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_comparacion.Rotation = 0D;
            this.btn_comparacion.Size = new System.Drawing.Size(300, 60);
            this.btn_comparacion.TabIndex = 4;
            this.btn_comparacion.Text = "COMPARACION";
            this.btn_comparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comparacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_comparacion.UseVisualStyleBackColor = true;
            this.btn_comparacion.Click += new System.EventHandler(this.btn_comparacion_Click);
            // 
            // btn_extraer
            // 
            this.btn_extraer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_extraer.FlatAppearance.BorderSize = 0;
            this.btn_extraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extraer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_extraer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extraer.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btn_extraer.IconColor = System.Drawing.Color.Ivory;
            this.btn_extraer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_extraer.IconSize = 55;
            this.btn_extraer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_extraer.Location = new System.Drawing.Point(0, 255);
            this.btn_extraer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_extraer.Name = "btn_extraer";
            this.btn_extraer.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_extraer.Rotation = 0D;
            this.btn_extraer.Size = new System.Drawing.Size(300, 60);
            this.btn_extraer.TabIndex = 3;
            this.btn_extraer.Text = "EXTRAER";
            this.btn_extraer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_extraer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_extraer.UseVisualStyleBackColor = true;
            this.btn_extraer.Click += new System.EventHandler(this.btn_extraer_Click);
            // 
            // btn_transferir
            // 
            this.btn_transferir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transferir.FlatAppearance.BorderSize = 0;
            this.btn_transferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transferir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_transferir.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transferir.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.btn_transferir.IconColor = System.Drawing.Color.Ivory;
            this.btn_transferir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_transferir.IconSize = 55;
            this.btn_transferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transferir.Location = new System.Drawing.Point(0, 195);
            this.btn_transferir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_transferir.Rotation = 0D;
            this.btn_transferir.Size = new System.Drawing.Size(300, 60);
            this.btn_transferir.TabIndex = 2;
            this.btn_transferir.Text = "TRANSFERIR";
            this.btn_transferir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transferir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_depositar.FlatAppearance.BorderSize = 0;
            this.btn_depositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depositar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_depositar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btn_depositar.IconColor = System.Drawing.Color.Ivory;
            this.btn_depositar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_depositar.IconSize = 55;
            this.btn_depositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depositar.Location = new System.Drawing.Point(0, 135);
            this.btn_depositar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_depositar.Rotation = 0D;
            this.btn_depositar.Size = new System.Drawing.Size(300, 60);
            this.btn_depositar.TabIndex = 1;
            this.btn_depositar.Text = "DEPOSITAR";
            this.btn_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depositar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 135);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Image = global::HackatonGrupo02.Properties.Resources.logoBilletera;
            this.btn_home.Location = new System.Drawing.Point(13, 7);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(275, 118);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelEscritorio.Controls.Add(this.lblCA);
            this.panelEscritorio.Controls.Add(this.lblSaldo);
            this.panelEscritorio.Controls.Add(this.lblBienvenido);
            this.panelEscritorio.Controls.Add(this.panelCuentas);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(300, 0);
            this.panelEscritorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(999, 768);
            this.panelEscritorio.TabIndex = 1;
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblCA.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCA.ForeColor = System.Drawing.Color.White;
            this.lblCA.Location = new System.Drawing.Point(39, 315);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(101, 30);
            this.lblCA.TabIndex = 1;
            this.lblCA.Text = "Saldo ca";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblSaldo.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(39, 271);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(98, 30);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo cc";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 28F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(160, 138);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(278, 57);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // panelCuentas
            // 
            this.panelCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelCuentas.Location = new System.Drawing.Point(20, 255);
            this.panelCuentas.Name = "panelCuentas";
            this.panelCuentas.Size = new System.Drawing.Size(956, 107);
            this.panelCuentas.TabIndex = 2;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Humnst777 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(20, 32);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(76, 29);
            this.lbFecha.TabIndex = 11;
            this.lbFecha.Text = "fecha";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.lbFecha);
            this.panelTop.Controls.Add(this.btnRegistrar);
            this.panelTop.Controls.Add(this.btnIngreso);
            this.panelTop.Controls.Add(this.txtPass);
            this.panelTop.Controls.Add(this.txtUsuario);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(999, 100);
            this.panelTop.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(880, 57);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 31);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngreso.Location = new System.Drawing.Point(880, 11);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(101, 32);
            this.btnIngreso.TabIndex = 7;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPass.Location = new System.Drawing.Point(633, 55);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(229, 30);
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "ingrese contraseña";
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(633, 11);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(229, 30);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "ingrese usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 768);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cordoba Pago";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_rendimiento;
        private FontAwesome.Sharp.IconButton btn_comparacion;
        private FontAwesome.Sharp.IconButton btn_extraer;
        private FontAwesome.Sharp.IconButton btn_transferir;
        private FontAwesome.Sharp.IconButton btn_depositar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_movimientos;
        private System.Windows.Forms.PictureBox btn_home;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton btn_tarjetas;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCA;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelCuentas;
    }
}

