namespace HackatonGrupo02.Forms
{
    partial class Movimientos
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
            this.panelMargen = new System.Windows.Forms.Panel();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniDestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridDepositos = new System.Windows.Forms.DataGridView();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMargen
            // 
            this.panelMargen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargen.Location = new System.Drawing.Point(0, 0);
            this.panelMargen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMargen.Name = "panelMargen";
            this.panelMargen.Size = new System.Drawing.Size(980, 100);
            this.panelMargen.TabIndex = 6;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDestinatario.Location = new System.Drawing.Point(15, 219);
            this.txtDestinatario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(349, 30);
            this.txtDestinatario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Destinatario";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMonto.Location = new System.Drawing.Point(15, 281);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(349, 30);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Monto a depositar";
            // 
            // txtDniDestinatario
            // 
            this.txtDniDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDniDestinatario.Location = new System.Drawing.Point(374, 219);
            this.txtDniDestinatario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDniDestinatario.Name = "txtDniDestinatario";
            this.txtDniDestinatario.Size = new System.Drawing.Size(349, 30);
            this.txtDniDestinatario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(374, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // gridDepositos
            // 
            this.gridDepositos.AllowUserToAddRows = false;
            this.gridDepositos.AllowUserToDeleteRows = false;
            this.gridDepositos.AllowUserToResizeColumns = false;
            this.gridDepositos.AllowUserToResizeRows = false;
            this.gridDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDepositos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepositos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridDepositos.Location = new System.Drawing.Point(13, 420);
            this.gridDepositos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridDepositos.Name = "gridDepositos";
            this.gridDepositos.RowHeadersVisible = false;
            this.gridDepositos.RowHeadersWidth = 51;
            this.gridDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepositos.Size = new System.Drawing.Size(948, 279);
            this.gridDepositos.TabIndex = 9;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDetalle.Location = new System.Drawing.Point(378, 281);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(349, 30);
            this.txtDetalle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(378, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalle";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(752, 219);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(198, 92);
            this.btnDepositar.TabIndex = 10;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "REALIZAR DEPOSITO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "MOVIMIENTOS DE CUENTA";
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.gridDepositos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDniDestinatario);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.panelMargen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMargen;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniDestinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridDepositos;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}