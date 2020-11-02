namespace HackatonGrupo02.CapaPresentacion.CapaWeb
{
    partial class Comparacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMargen = new System.Windows.Forms.Panel();
            this.txtMontoAComparar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTarjeta1 = new System.Windows.Forms.DataGridView();
            this.gridTarjeta2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarjeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarjeta2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 33);
            this.label5.TabIndex = 31;
            this.label5.Text = "COMPARAR OPCIONES DE PAGO";
            // 
            // panelMargen
            // 
            this.panelMargen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargen.Location = new System.Drawing.Point(0, 0);
            this.panelMargen.Margin = new System.Windows.Forms.Padding(2);
            this.panelMargen.Name = "panelMargen";
            this.panelMargen.Size = new System.Drawing.Size(735, 81);
            this.panelMargen.TabIndex = 19;
            // 
            // txtMontoAComparar
            // 
            this.txtMontoAComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMontoAComparar.Location = new System.Drawing.Point(12, 199);
            this.txtMontoAComparar.Name = "txtMontoAComparar";
            this.txtMontoAComparar.Size = new System.Drawing.Size(133, 30);
            this.txtMontoAComparar.TabIndex = 36;
            this.txtMontoAComparar.TextChanged += new System.EventHandler(this.txtMontoAComparar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Monto a comparar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridTarjeta1
            // 
            this.gridTarjeta1.AllowUserToAddRows = false;
            this.gridTarjeta1.AllowUserToDeleteRows = false;
            this.gridTarjeta1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTarjeta1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTarjeta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTarjeta1.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTarjeta1.Location = new System.Drawing.Point(12, 253);
            this.gridTarjeta1.Name = "gridTarjeta1";
            this.gridTarjeta1.RowHeadersVisible = false;
            this.gridTarjeta1.Size = new System.Drawing.Size(337, 376);
            this.gridTarjeta1.TabIndex = 37;
            // 
            // gridTarjeta2
            // 
            this.gridTarjeta2.AllowUserToAddRows = false;
            this.gridTarjeta2.AllowUserToDeleteRows = false;
            this.gridTarjeta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTarjeta2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTarjeta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTarjeta2.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTarjeta2.Location = new System.Drawing.Point(386, 253);
            this.gridTarjeta2.Name = "gridTarjeta2";
            this.gridTarjeta2.RowHeadersVisible = false;
            this.gridTarjeta2.Size = new System.Drawing.Size(337, 376);
            this.gridTarjeta2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tarjeta 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(522, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tarjeta 2";
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(169, 199);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(90, 30);
            this.btnComparar.TabIndex = 38;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // Comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 634);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.gridTarjeta2);
            this.Controls.Add(this.gridTarjeta1);
            this.Controls.Add(this.txtMontoAComparar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelMargen);
            this.Name = "Comparacion";
            this.Text = "Comparacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridTarjeta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarjeta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMargen;
        private System.Windows.Forms.TextBox txtMontoAComparar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridTarjeta1;
        private System.Windows.Forms.DataGridView gridTarjeta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComparar;
    }
}