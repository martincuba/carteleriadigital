namespace Inicio
{
    partial class VentanaVistaPrevia
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
            this.components = new System.ComponentModel.Container();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.TimmerPaso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(13, 13);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(259, 236);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
            // 
            // TimmerPaso
            // 
            this.TimmerPaso.Enabled = true;
            this.TimmerPaso.Tick += new System.EventHandler(this.TimmerPaso_Tick);
            // 
            // VentanaVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbImagenes);
            this.Name = "VentanaVistaPrevia";
            this.Text = "VentanaVistaPrevia";
            this.Load += new System.EventHandler(this.VentanaVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Timer TimmerPaso;
    }
}