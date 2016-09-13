namespace Inicio
{
    partial class VentanaSeleccionarMedia
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
            this.gbUbicacionSecuencia = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btAdelantar = new System.Windows.Forms.Button();
            this.btRetroceder = new System.Windows.Forms.Button();
            this.btListo = new System.Windows.Forms.Button();
            this.btVistaPrevia = new System.Windows.Forms.Button();
            this.fdImagen = new System.Windows.Forms.OpenFileDialog();
            this.btAtras = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btExaminar = new System.Windows.Forms.Button();
            this.lbPosicion = new System.Windows.Forms.Label();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.gbUbicacionSecuencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUbicacionSecuencia
            // 
            this.gbUbicacionSecuencia.Controls.Add(this.numDuracion);
            this.gbUbicacionSecuencia.Controls.Add(this.lbDuracion);
            this.gbUbicacionSecuencia.Controls.Add(this.lbPosicion);
            this.gbUbicacionSecuencia.Controls.Add(this.pbImagen);
            this.gbUbicacionSecuencia.Controls.Add(this.btAdelantar);
            this.gbUbicacionSecuencia.Controls.Add(this.btRetroceder);
            this.gbUbicacionSecuencia.Location = new System.Drawing.Point(12, 67);
            this.gbUbicacionSecuencia.Name = "gbUbicacionSecuencia";
            this.gbUbicacionSecuencia.Size = new System.Drawing.Size(227, 210);
            this.gbUbicacionSecuencia.TabIndex = 14;
            this.gbUbicacionSecuencia.TabStop = false;
            this.gbUbicacionSecuencia.Text = "Ubicación en  la Secuencia";
            this.gbUbicacionSecuencia.Visible = false;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(6, 19);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(215, 116);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btAdelantar
            // 
            this.btAdelantar.Location = new System.Drawing.Point(146, 141);
            this.btAdelantar.Name = "btAdelantar";
            this.btAdelantar.Size = new System.Drawing.Size(75, 23);
            this.btAdelantar.TabIndex = 2;
            this.btAdelantar.Text = "Adelantar";
            this.btAdelantar.UseVisualStyleBackColor = true;
            this.btAdelantar.Click += new System.EventHandler(this.btAdelantar_Click);
            // 
            // btRetroceder
            // 
            this.btRetroceder.Location = new System.Drawing.Point(6, 141);
            this.btRetroceder.Name = "btRetroceder";
            this.btRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btRetroceder.TabIndex = 3;
            this.btRetroceder.Text = "Retroceder";
            this.btRetroceder.UseVisualStyleBackColor = true;
            this.btRetroceder.Click += new System.EventHandler(this.btRetroceder_Click);
            // 
            // btListo
            // 
            this.btListo.Location = new System.Drawing.Point(276, 241);
            this.btListo.Name = "btListo";
            this.btListo.Size = new System.Drawing.Size(75, 23);
            this.btListo.TabIndex = 13;
            this.btListo.Text = "Listo";
            this.btListo.UseVisualStyleBackColor = true;
            this.btListo.Click += new System.EventHandler(this.btListo_Click);
            // 
            // btVistaPrevia
            // 
            this.btVistaPrevia.Location = new System.Drawing.Point(276, 213);
            this.btVistaPrevia.Name = "btVistaPrevia";
            this.btVistaPrevia.Size = new System.Drawing.Size(75, 23);
            this.btVistaPrevia.TabIndex = 12;
            this.btVistaPrevia.Text = "VistaPrevia";
            this.btVistaPrevia.UseVisualStyleBackColor = true;
            this.btVistaPrevia.Visible = false;
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
            // 
            // fdImagen
            // 
            this.fdImagen.FileName = "openFileDialog1";
            this.fdImagen.Filter = "(*.BMP;*.JPEG;*.AVI;*.MP4;*.WMV)|*.BMP;*.JPG;*.GIF;*.JPEG;*.AVI;*.MP4;*.WMV";
            this.fdImagen.Multiselect = true;
            // 
            // btAtras
            // 
            this.btAtras.Enabled = false;
            this.btAtras.Location = new System.Drawing.Point(13, 29);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 15;
            this.btAtras.Text = "Atrás";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Enabled = false;
            this.btSiguiente.Location = new System.Drawing.Point(94, 29);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 16;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Location = new System.Drawing.Point(175, 29);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 17;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btExaminar
            // 
            this.btExaminar.Location = new System.Drawing.Point(256, 29);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(75, 23);
            this.btExaminar.TabIndex = 18;
            this.btExaminar.Text = "Examinar";
            this.btExaminar.UseVisualStyleBackColor = true;
            this.btExaminar.Click += new System.EventHandler(this.btExaminar_Click);
            // 
            // lbPosicion
            // 
            this.lbPosicion.AutoSize = true;
            this.lbPosicion.Location = new System.Drawing.Point(96, 146);
            this.lbPosicion.Name = "lbPosicion";
            this.lbPosicion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPosicion.Size = new System.Drawing.Size(37, 13);
            this.lbPosicion.TabIndex = 4;
            this.lbPosicion.Text = "0 de 0";
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Location = new System.Drawing.Point(43, 179);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(67, 13);
            this.lbDuracion.TabIndex = 5;
            this.lbDuracion.Text = "Duración (s):";
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(119, 177);
            this.numDuracion.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(60, 20);
            this.numDuracion.TabIndex = 6;
            this.numDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuracion.ValueChanged += new System.EventHandler(this.numDuracion_ValueChanged);
            // 
            // VentanaSeleccionarMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.btExaminar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.gbUbicacionSecuencia);
            this.Controls.Add(this.btListo);
            this.Controls.Add(this.btVistaPrevia);
            this.Name = "VentanaSeleccionarMedia";
            this.Text = "VentanaSeleccionarMedia";
            this.gbUbicacionSecuencia.ResumeLayout(false);
            this.gbUbicacionSecuencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUbicacionSecuencia;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btAdelantar;
        private System.Windows.Forms.Button btRetroceder;
        private System.Windows.Forms.Button btListo;
        private System.Windows.Forms.Button btVistaPrevia;
        private System.Windows.Forms.OpenFileDialog fdImagen;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btExaminar;
        private System.Windows.Forms.Label lbPosicion;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label lbDuracion;
    }
}