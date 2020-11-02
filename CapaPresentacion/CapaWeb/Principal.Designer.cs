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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_tarjetas = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_movimientos = new FontAwesome.Sharp.IconButton();
            this.btn_rendimiento = new FontAwesome.Sharp.IconButton();
            this.btn_comparacion = new FontAwesome.Sharp.IconButton();
            this.btn_depositar = new FontAwesome.Sharp.IconButton();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
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
            this.panelMenu.Controls.Add(this.btn_depositar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 624);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(225, 0);
            this.panelEscritorio.Margin = new System.Windows.Forms.Padding(2);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(749, 624);
            this.panelEscritorio.TabIndex = 1;
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblCA.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCA.ForeColor = System.Drawing.Color.White;
            this.lblCA.Location = new System.Drawing.Point(208, 81);
            this.lblCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(79, 23);
            this.lblCA.TabIndex = 1;
            this.lblCA.Text = "Saldo ca";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblSaldo.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(11, 82);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(77, 23);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo cc";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 28F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(7, 34);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(225, 46);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Humnst777 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(11, 12);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(62, 22);
            this.lbFecha.TabIndex = 11;
            this.lbFecha.Text = "fecha";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.lblCA);
            this.panelTop.Controls.Add(this.lbFecha);
            this.panelTop.Controls.Add(this.lblSaldo);
            this.panelTop.Controls.Add(this.btnRegistrar);
            this.panelTop.Controls.Add(this.lblBienvenido);
            this.panelTop.Controls.Add(this.btnIngreso);
            this.panelTop.Controls.Add(this.txtPass);
            this.panelTop.Controls.Add(this.txtUsuario);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(225, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(749, 111);
            this.panelTop.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(639, 59);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 41);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngreso.Location = new System.Drawing.Point(639, 6);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(100, 45);
            this.btnIngreso.TabIndex = 7;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPass.Location = new System.Drawing.Point(460, 56);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '9';
            this.txtPass.Size = new System.Drawing.Size(173, 46);
            this.txtPass.TabIndex = 9;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsuario.Location = new System.Drawing.Point(460, 6);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 46);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "ingrese usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconButton2.IconColor = System.Drawing.Color.Ivory;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 368);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(225, 49);
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
            this.btn_tarjetas.Enabled = false;
            this.btn_tarjetas.FlatAppearance.BorderSize = 0;
            this.btn_tarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tarjetas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_tarjetas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tarjetas.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btn_tarjetas.IconColor = System.Drawing.Color.Ivory;
            this.btn_tarjetas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tarjetas.IconSize = 55;
            this.btn_tarjetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tarjetas.Location = new System.Drawing.Point(0, 319);
            this.btn_tarjetas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tarjetas.Name = "btn_tarjetas";
            this.btn_tarjetas.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_tarjetas.Rotation = 0D;
            this.btn_tarjetas.Size = new System.Drawing.Size(225, 49);
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
            this.iconButton1.Location = new System.Drawing.Point(0, 575);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(225, 49);
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
            this.btn_movimientos.Enabled = false;
            this.btn_movimientos.FlatAppearance.BorderSize = 0;
            this.btn_movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movimientos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_movimientos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movimientos.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btn_movimientos.IconColor = System.Drawing.Color.Ivory;
            this.btn_movimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_movimientos.IconSize = 55;
            this.btn_movimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_movimientos.Location = new System.Drawing.Point(0, 270);
            this.btn_movimientos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_movimientos.Name = "btn_movimientos";
            this.btn_movimientos.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_movimientos.Rotation = 0D;
            this.btn_movimientos.Size = new System.Drawing.Size(225, 49);
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
            this.btn_rendimiento.Enabled = false;
            this.btn_rendimiento.FlatAppearance.BorderSize = 0;
            this.btn_rendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendimiento.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_rendimiento.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rendimiento.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_rendimiento.IconColor = System.Drawing.Color.Ivory;
            this.btn_rendimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rendimiento.IconSize = 55;
            this.btn_rendimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rendimiento.Location = new System.Drawing.Point(0, 221);
            this.btn_rendimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rendimiento.Name = "btn_rendimiento";
            this.btn_rendimiento.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_rendimiento.Rotation = 0D;
            this.btn_rendimiento.Size = new System.Drawing.Size(225, 49);
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
            this.btn_comparacion.Enabled = false;
            this.btn_comparacion.FlatAppearance.BorderSize = 0;
            this.btn_comparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comparacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_comparacion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comparacion.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_comparacion.IconColor = System.Drawing.Color.Ivory;
            this.btn_comparacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_comparacion.IconSize = 55;
            this.btn_comparacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comparacion.Location = new System.Drawing.Point(0, 172);
            this.btn_comparacion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comparacion.Name = "btn_comparacion";
            this.btn_comparacion.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_comparacion.Rotation = 0D;
            this.btn_comparacion.Size = new System.Drawing.Size(225, 49);
            this.btn_comparacion.TabIndex = 4;
            this.btn_comparacion.Text = "COMPARACION";
            this.btn_comparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comparacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_comparacion.UseVisualStyleBackColor = true;
            this.btn_comparacion.Click += new System.EventHandler(this.btn_comparacion_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_depositar.Enabled = false;
            this.btn_depositar.FlatAppearance.BorderSize = 0;
            this.btn_depositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depositar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_depositar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btn_depositar.IconColor = System.Drawing.Color.Ivory;
            this.btn_depositar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_depositar.IconSize = 55;
            this.btn_depositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depositar.Location = new System.Drawing.Point(0, 110);
            this.btn_depositar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_depositar.Rotation = 0D;
            this.btn_depositar.Size = new System.Drawing.Size(225, 62);
            this.btn_depositar.TabIndex = 1;
            this.btn_depositar.Text = "PAGAR O TRANSFERIR";
            this.btn_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depositar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Image = global::HackatonGrupo02.Properties.Resources.logoBilletera;
            this.btn_home.Location = new System.Drawing.Point(10, 6);
            this.btn_home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(206, 96);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 624);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cordoba Pago";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_rendimiento;
        private FontAwesome.Sharp.IconButton btn_comparacion;
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
    }
}

