namespace Inicio
{
    partial class VentanaConfigHorario
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
            this.btEditarFecha = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btValidar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.gbRangoFecha = new System.Windows.Forms.GroupBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.tbHoraFin = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoraInicio = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.mtHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.mtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.gbRangoFecha.SuspendLayout();
            this.gbHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoraInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditarFecha
            // 
            this.btEditarFecha.Enabled = false;
            this.btEditarFecha.Location = new System.Drawing.Point(413, 126);
            this.btEditarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btEditarFecha.Name = "btEditarFecha";
            this.btEditarFecha.Size = new System.Drawing.Size(59, 22);
            this.btEditarFecha.TabIndex = 60;
            this.btEditarFecha.Text = "Editar";
            this.btEditarFecha.UseVisualStyleBackColor = true;
            this.btEditarFecha.Click += new System.EventHandler(this.btEditarFecha_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Enabled = false;
            this.btAgregar.Location = new System.Drawing.Point(493, 126);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(59, 22);
            this.btAgregar.TabIndex = 57;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(157, 124);
            this.btEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(64, 22);
            this.btEditar.TabIndex = 59;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btValidar
            // 
            this.btValidar.Enabled = false;
            this.btValidar.Location = new System.Drawing.Point(333, 126);
            this.btValidar.Margin = new System.Windows.Forms.Padding(2);
            this.btValidar.Name = "btValidar";
            this.btValidar.Size = new System.Drawing.Size(59, 22);
            this.btValidar.TabIndex = 56;
            this.btValidar.Text = "Validar";
            this.btValidar.UseVisualStyleBackColor = true;
            this.btValidar.Click += new System.EventHandler(this.btValidar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(81, 124);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(64, 22);
            this.btAceptar.TabIndex = 55;
            this.btAceptar.Text = "Confirmar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // gbRangoFecha
            // 
            this.gbRangoFecha.Controls.Add(this.dtFechaFin);
            this.gbRangoFecha.Controls.Add(this.dtFechaInicio);
            this.gbRangoFecha.Controls.Add(this.label3);
            this.gbRangoFecha.Controls.Add(this.label4);
            this.gbRangoFecha.Enabled = false;
            this.gbRangoFecha.Location = new System.Drawing.Point(307, 11);
            this.gbRangoFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gbRangoFecha.Name = "gbRangoFecha";
            this.gbRangoFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gbRangoFecha.Size = new System.Drawing.Size(278, 108);
            this.gbRangoFecha.TabIndex = 58;
            this.gbRangoFecha.TabStop = false;
            this.gbRangoFecha.Text = "Rango de Fecha";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(97, 65);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dtFechaFin.TabIndex = 1;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaFin_ValueChanged);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(97, 31);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(151, 20);
            this.dtFechaInicio.TabIndex = 0;
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de Inicio";
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.tbHoraFin);
            this.gbHorario.Controls.Add(this.label2);
            this.gbHorario.Controls.Add(this.tbHoraInicio);
            this.gbHorario.Controls.Add(this.label1);
            this.gbHorario.Controls.Add(this.mtHoraFin);
            this.gbHorario.Controls.Add(this.mtHoraInicio);
            this.gbHorario.Location = new System.Drawing.Point(20, 11);
            this.gbHorario.Margin = new System.Windows.Forms.Padding(2);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Padding = new System.Windows.Forms.Padding(2);
            this.gbHorario.Size = new System.Drawing.Size(278, 108);
            this.gbHorario.TabIndex = 54;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario";
            // 
            // tbHoraFin
            // 
            this.tbHoraFin.Location = new System.Drawing.Point(137, 54);
            this.tbHoraFin.Maximum = 144;
            this.tbHoraFin.Name = "tbHoraFin";
            this.tbHoraFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHoraFin.Size = new System.Drawing.Size(104, 45);
            this.tbHoraFin.TabIndex = 51;
            this.tbHoraFin.ValueChanged += new System.EventHandler(this.tbHoraFin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hora fin:";
            // 
            // tbHoraInicio
            // 
            this.tbHoraInicio.Location = new System.Drawing.Point(137, 20);
            this.tbHoraInicio.Maximum = 143;
            this.tbHoraInicio.Name = "tbHoraInicio";
            this.tbHoraInicio.Size = new System.Drawing.Size(104, 45);
            this.tbHoraInicio.TabIndex = 50;
            this.tbHoraInicio.ValueChanged += new System.EventHandler(this.tbHoraInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hora inicio:";
            // 
            // mtHoraFin
            // 
            this.mtHoraFin.Location = new System.Drawing.Point(81, 54);
            this.mtHoraFin.Mask = "00:00";
            this.mtHoraFin.Name = "mtHoraFin";
            this.mtHoraFin.ReadOnly = true;
            this.mtHoraFin.Size = new System.Drawing.Size(38, 20);
            this.mtHoraFin.TabIndex = 47;
            this.mtHoraFin.Text = "2359";
            this.mtHoraFin.ValidatingType = typeof(System.DateTime);
            // 
            // mtHoraInicio
            // 
            this.mtHoraInicio.Location = new System.Drawing.Point(81, 28);
            this.mtHoraInicio.Mask = "00:00";
            this.mtHoraInicio.Name = "mtHoraInicio";
            this.mtHoraInicio.ReadOnly = true;
            this.mtHoraInicio.Size = new System.Drawing.Size(38, 20);
            this.mtHoraInicio.TabIndex = 46;
            this.mtHoraInicio.Text = "0000";
            this.mtHoraInicio.ValidatingType = typeof(System.DateTime);
            this.mtHoraInicio.TextChanged += new System.EventHandler(this.mtHoraInicio_TextChanged);
            // 
            // VentanaConfigHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 333);
            this.Controls.Add(this.btEditarFecha);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btValidar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbRangoFecha);
            this.Controls.Add(this.gbHorario);
            this.Name = "VentanaConfigHorario";
            this.Text = "Configurar Horario";
            this.gbRangoFecha.ResumeLayout(false);
            this.gbRangoFecha.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoraInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditarFecha;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btValidar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.GroupBox gbRangoFecha;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.TrackBar tbHoraFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbHoraInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtHoraFin;
        private System.Windows.Forms.MaskedTextBox mtHoraInicio;
    }
}