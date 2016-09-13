namespace Inicio
{
    partial class VentanaCampaña
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
            this.button5 = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.llSeleccionarRango = new System.Windows.Forms.LinkLabel();
            this.llMediaCampaña = new System.Windows.Forms.LinkLabel();
            this.btValidarNombre = new System.Windows.Forms.Button();
            this.tbNombreCampania = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llbHora = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Enabled = false;
            this.btAceptar.Location = new System.Drawing.Point(31, 227);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Crear";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llbHora);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.llSeleccionarRango);
            this.groupBox1.Controls.Add(this.llMediaCampaña);
            this.groupBox1.Controls.Add(this.btValidarNombre);
            this.groupBox1.Controls.Add(this.tbNombreCampania);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campaña Publicitaria";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(286, 36);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 42;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Visible = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // llSeleccionarRango
            // 
            this.llSeleccionarRango.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.llSeleccionarRango.AutoSize = true;
            this.llSeleccionarRango.Enabled = false;
            this.llSeleccionarRango.Location = new System.Drawing.Point(104, 110);
            this.llSeleccionarRango.Name = "llSeleccionarRango";
            this.llSeleccionarRango.Size = new System.Drawing.Size(151, 13);
            this.llSeleccionarRango.TabIndex = 41;
            this.llSeleccionarRango.TabStop = true;
            this.llSeleccionarRango.Text = "Seleccionar Rango de Fechas";
            // 
            // llMediaCampaña
            // 
            this.llMediaCampaña.ActiveLinkColor = System.Drawing.Color.SpringGreen;
            this.llMediaCampaña.AutoSize = true;
            this.llMediaCampaña.Enabled = false;
            this.llMediaCampaña.Location = new System.Drawing.Point(95, 87);
            this.llMediaCampaña.Name = "llMediaCampaña";
            this.llMediaCampaña.Size = new System.Drawing.Size(169, 13);
            this.llMediaCampaña.TabIndex = 29;
            this.llMediaCampaña.TabStop = true;
            this.llMediaCampaña.Text = "Seleccionar Media de la Campaña";
            this.llMediaCampaña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMediaCampaña_LinkClicked);
            // 
            // btValidarNombre
            // 
            this.btValidarNombre.Location = new System.Drawing.Point(286, 36);
            this.btValidarNombre.Name = "btValidarNombre";
            this.btValidarNombre.Size = new System.Drawing.Size(75, 23);
            this.btValidarNombre.TabIndex = 7;
            this.btValidarNombre.Text = "Validar";
            this.btValidarNombre.UseVisualStyleBackColor = true;
            this.btValidarNombre.Click += new System.EventHandler(this.btValidarNombre_Click);
            // 
            // tbNombreCampania
            // 
            this.tbNombreCampania.Location = new System.Drawing.Point(85, 39);
            this.tbNombreCampania.Name = "tbNombreCampania";
            this.tbNombreCampania.Size = new System.Drawing.Size(174, 20);
            this.tbNombreCampania.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // llbHora
            // 
            this.llbHora.AutoSize = true;
            this.llbHora.Enabled = false;
            this.llbHora.Location = new System.Drawing.Point(95, 136);
            this.llbHora.Name = "llbHora";
            this.llbHora.Size = new System.Drawing.Size(172, 13);
            this.llbHora.TabIndex = 43;
            this.llbHora.TabStop = true;
            this.llbHora.Text = "Seleccionar Hora de Inicio y de Fin";
            this.llbHora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHora_LinkClicked);
            // 
            // VentanaCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 273);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaCampaña";
            this.Text = "VentanaCampaña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llSeleccionarRango;
        private System.Windows.Forms.LinkLabel llMediaCampaña;
        private System.Windows.Forms.Button btValidarNombre;
        private System.Windows.Forms.TextBox tbNombreCampania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.LinkLabel llbHora;
    }
}