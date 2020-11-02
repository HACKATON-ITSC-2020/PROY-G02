namespace HackatonGrupo02.Forms
{
    partial class Tarjetas
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
            this.panelMargen = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btn_debVisa = new FontAwesome.Sharp.IconButton();
            this.btn_credMaster = new FontAwesome.Sharp.IconButton();
            this.btn_debMaster = new FontAwesome.Sharp.IconButton();
            this.btn_credVisa = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_credDiscov = new FontAwesome.Sharp.IconButton();
            this.btn_credStripe = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreditoUsuario = new System.Windows.Forms.Label();
            this.lblDebitoUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMargen
            // 
            this.panelMargen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargen.Location = new System.Drawing.Point(0, 0);
            this.panelMargen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMargen.Name = "panelMargen";
            this.panelMargen.Size = new System.Drawing.Size(735, 81);
            this.panelMargen.TabIndex = 5;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenido.Location = new System.Drawing.Point(84, 185);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(260, 23);
            this.lblBienvenido.TabIndex = 7;
            this.lblBienvenido.Text = "Tarjetas de debito disponibles";
            // 
            // btn_debVisa
            // 
            this.btn_debVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_debVisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_debVisa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_debVisa.IconChar = FontAwesome.Sharp.IconChar.CcVisa;
            this.btn_debVisa.IconColor = System.Drawing.Color.Black;
            this.btn_debVisa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_debVisa.IconSize = 70;
            this.btn_debVisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debVisa.Location = new System.Drawing.Point(88, 222);
            this.btn_debVisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_debVisa.Name = "btn_debVisa";
            this.btn_debVisa.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_debVisa.Rotation = 0D;
            this.btn_debVisa.Size = new System.Drawing.Size(58, 50);
            this.btn_debVisa.TabIndex = 8;
            this.btn_debVisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debVisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_debVisa.UseVisualStyleBackColor = true;
            this.btn_debVisa.Click += new System.EventHandler(this.btn_debVisa_Click);
            // 
            // btn_credMaster
            // 
            this.btn_credMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credMaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credMaster.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_credMaster.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.btn_credMaster.IconColor = System.Drawing.Color.Black;
            this.btn_credMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_credMaster.IconSize = 70;
            this.btn_credMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credMaster.Location = new System.Drawing.Point(170, 330);
            this.btn_credMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_credMaster.Name = "btn_credMaster";
            this.btn_credMaster.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_credMaster.Rotation = 0D;
            this.btn_credMaster.Size = new System.Drawing.Size(58, 50);
            this.btn_credMaster.TabIndex = 9;
            this.btn_credMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_credMaster.UseVisualStyleBackColor = true;
            this.btn_credMaster.Click += new System.EventHandler(this.btn_credMaster_Click);
            // 
            // btn_debMaster
            // 
            this.btn_debMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_debMaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_debMaster.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_debMaster.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.btn_debMaster.IconColor = System.Drawing.Color.Black;
            this.btn_debMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_debMaster.IconSize = 70;
            this.btn_debMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debMaster.Location = new System.Drawing.Point(170, 222);
            this.btn_debMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_debMaster.Name = "btn_debMaster";
            this.btn_debMaster.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_debMaster.Rotation = 0D;
            this.btn_debMaster.Size = new System.Drawing.Size(58, 50);
            this.btn_debMaster.TabIndex = 10;
            this.btn_debMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_debMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_debMaster.UseVisualStyleBackColor = true;
            this.btn_debMaster.Click += new System.EventHandler(this.btn_debMaster_Click);
            // 
            // btn_credVisa
            // 
            this.btn_credVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credVisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credVisa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_credVisa.IconChar = FontAwesome.Sharp.IconChar.CcVisa;
            this.btn_credVisa.IconColor = System.Drawing.Color.Black;
            this.btn_credVisa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_credVisa.IconSize = 70;
            this.btn_credVisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credVisa.Location = new System.Drawing.Point(88, 330);
            this.btn_credVisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_credVisa.Name = "btn_credVisa";
            this.btn_credVisa.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_credVisa.Rotation = 0D;
            this.btn_credVisa.Size = new System.Drawing.Size(58, 50);
            this.btn_credVisa.TabIndex = 11;
            this.btn_credVisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credVisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_credVisa.UseVisualStyleBackColor = true;
            this.btn_credVisa.Click += new System.EventHandler(this.btn_credVisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tarjetas de credito disponibles";
            // 
            // btn_credDiscov
            // 
            this.btn_credDiscov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credDiscov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credDiscov.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_credDiscov.IconChar = FontAwesome.Sharp.IconChar.CcDiscover;
            this.btn_credDiscov.IconColor = System.Drawing.Color.Black;
            this.btn_credDiscov.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_credDiscov.IconSize = 70;
            this.btn_credDiscov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credDiscov.Location = new System.Drawing.Point(251, 330);
            this.btn_credDiscov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_credDiscov.Name = "btn_credDiscov";
            this.btn_credDiscov.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_credDiscov.Rotation = 0D;
            this.btn_credDiscov.Size = new System.Drawing.Size(58, 50);
            this.btn_credDiscov.TabIndex = 13;
            this.btn_credDiscov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credDiscov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_credDiscov.UseVisualStyleBackColor = true;
            this.btn_credDiscov.Click += new System.EventHandler(this.btn_credDiscov_Click);
            // 
            // btn_credStripe
            // 
            this.btn_credStripe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credStripe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credStripe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_credStripe.IconChar = FontAwesome.Sharp.IconChar.CcStripe;
            this.btn_credStripe.IconColor = System.Drawing.Color.Black;
            this.btn_credStripe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_credStripe.IconSize = 70;
            this.btn_credStripe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credStripe.Location = new System.Drawing.Point(333, 330);
            this.btn_credStripe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_credStripe.Name = "btn_credStripe";
            this.btn_credStripe.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_credStripe.Rotation = 0D;
            this.btn_credStripe.Size = new System.Drawing.Size(58, 50);
            this.btn_credStripe.TabIndex = 14;
            this.btn_credStripe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_credStripe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_credStripe.UseVisualStyleBackColor = true;
            this.btn_credStripe.Click += new System.EventHandler(this.btn_credStripe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "AÑADIR TARJETAS A SU CUENTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblCreditoUsuario);
            this.panel1.Controls.Add(this.lblDebitoUsuario);
            this.panel1.Location = new System.Drawing.Point(9, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 162);
            this.panel1.TabIndex = 16;
            // 
            // lblCreditoUsuario
            // 
            this.lblCreditoUsuario.AutoSize = true;
            this.lblCreditoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditoUsuario.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblCreditoUsuario.Location = new System.Drawing.Point(20, 104);
            this.lblCreditoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditoUsuario.Name = "lblCreditoUsuario";
            this.lblCreditoUsuario.Size = new System.Drawing.Size(456, 23);
            this.lblCreditoUsuario.TabIndex = 18;
            this.lblCreditoUsuario.Text = "La tarjeta de credito activa en tu cuenta es: NINGUNA";
            // 
            // lblDebitoUsuario
            // 
            this.lblDebitoUsuario.AutoSize = true;
            this.lblDebitoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDebitoUsuario.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblDebitoUsuario.Location = new System.Drawing.Point(20, 41);
            this.lblDebitoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebitoUsuario.Name = "lblDebitoUsuario";
            this.lblDebitoUsuario.Size = new System.Drawing.Size(456, 23);
            this.lblDebitoUsuario.TabIndex = 17;
            this.lblDebitoUsuario.Text = "La tarjeta de credito activa en tu cuenta es: NINGUNA";
            // 
            // Tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_credStripe);
            this.Controls.Add(this.btn_credDiscov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_credVisa);
            this.Controls.Add(this.btn_debMaster);
            this.Controls.Add(this.btn_credMaster);
            this.Controls.Add(this.btn_debVisa);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panelMargen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tarjetas";
            this.Text = "Tarjetas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMargen;
        private System.Windows.Forms.Label lblBienvenido;
        private FontAwesome.Sharp.IconButton btn_debVisa;
        private FontAwesome.Sharp.IconButton btn_credMaster;
        private FontAwesome.Sharp.IconButton btn_debMaster;
        private FontAwesome.Sharp.IconButton btn_credVisa;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_credDiscov;
        private FontAwesome.Sharp.IconButton btn_credStripe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreditoUsuario;
        private System.Windows.Forms.Label lblDebitoUsuario;
    }
}