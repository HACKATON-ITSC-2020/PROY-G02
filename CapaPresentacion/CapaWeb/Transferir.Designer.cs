namespace HackatonGrupo02.CapaPresentacion.CapaWeb
{
    partial class Transferir
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
            this.SuspendLayout();
            // 
            // panelMargen
            // 
            this.panelMargen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargen.Location = new System.Drawing.Point(0, 0);
            this.panelMargen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMargen.Name = "panelMargen";
            this.panelMargen.Size = new System.Drawing.Size(980, 100);
            this.panelMargen.TabIndex = 7;
            // 
            // Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 721);
            this.Controls.Add(this.panelMargen);
            this.Name = "Transferir";
            this.Text = "Transferir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMargen;
    }
}