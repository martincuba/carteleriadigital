using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class VentanaCampaña : Form
    {
        private FachadaEvento aFachadaEvento = new FachadaEvento();
        private FachadaMedia aFachadaMedia = new FachadaMedia();
        private int aCarteleraId;
        private List<Media> listaMedia = new List<Media>();
        private List<RangoFecha> listaRangos = new List<RangoFecha>();
        private TimeSpan aHoraInicio;
        private TimeSpan aHoraFin;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pFachadaEvento">Parámetro</param>
        public VentanaCampaña(FachadaEvento pFachadaEvento, int carteleraId)
        {
            InitializeComponent();
            this.aFachadaEvento = pFachadaEvento;
            this.aCarteleraId = carteleraId;
        }

        /// <summary>
        /// Propiedad de sólo lectura
        /// </summary>
        public FachadaMedia FachadaMedia
        {
            get { return this.aFachadaMedia; }
            set { this.aFachadaMedia = value; }
        }

        /// <summary>
        /// Propiedad de sólo lectura
        /// </summary>
        public FachadaEvento FachadaEvento
        {
            get { return this.aFachadaEvento; }
            set { this.aFachadaEvento = value; }
        }

        /// <summary>
        /// Propiedad de solo lectura
        /// </summary>
        public List<Media> ListaDeMedia
        {
            get { return this.listaMedia; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public TimeSpan HoraInicio
        {
            get { return this.aHoraInicio; }
            set { this.aHoraInicio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public TimeSpan HoraFin
        {
            get { return this.aHoraFin; }
            set { this.aHoraFin = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public List<RangoFecha> ListaDeRangos
        {
            get { return this.listaRangos; }
            set { this.listaRangos = value; }
        }

        private void llMediaCampaña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaSeleccionarMedia VentanaSeleccionMedia = new VentanaSeleccionarMedia(ListaDeMedia, FachadaMedia);

            if (VentanaSeleccionMedia.ShowDialog() == DialogResult.OK)
            {
                this.listaMedia = (VentanaSeleccionMedia.ListaMedia);
                if (CondicionesCampaña())
                    btAceptar.Visible = true;

            }

            else { MessageBox.Show("CERRO SIN GUARDAR"); }
        }

        /// <summary>
        /// Verdadero si nos encontramos en condiciones de crear la campaña, es decir tenemos todos los atributos.
        /// </summary>
        /// <returns></returns>
        private bool CondicionesCampaña()
        {
            if ((btValidarNombre.Visible == false) && (ListaDeMedia.Count > 0) && (listaRangos.Count > 0) && (HoraFin.CompareTo(HoraInicio)>0) && (HoraInicio.TotalMinutes>0) )
            {
                return true;
            }
            else
                return false;
        }




        /// <summary>
        /// Valida el nombre de una campaña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btValidarNombre_Click(object sender, EventArgs e)
        {
            if (tbNombreCampania.Text != "")
            {
                //VALIDAR NOMBRE DE CAMPAÑA
                if (!FachadaEvento.ConflictoNombresEvento(tbNombreCampania.Text, aCarteleraId))
                {
                    BotonValidar();
                }
                else
                {
                    MessageBox.Show("Nombre no disponible");
                } 
            }
        }

        /// <summary>
        /// Activa la visibilidad de los elementos de la pantalla.
        /// </summary>
        private void BotonValidar()
        {
            llMediaCampaña.Enabled = true;
            llSeleccionarRango.Enabled = true;
            llbHora.Enabled = true;
            tbNombreCampania.Enabled = false;
            btValidarNombre.Visible = false;
            btEditar.Visible = true;
            if (CondicionesCampaña())
                btAceptar.Visible = true;
        }

        /// <summary>
        /// Desactiva la visibilidad de los elementos de la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditar_Click(object sender, EventArgs e)
        {
            llMediaCampaña.Enabled = false;
            llSeleccionarRango.Enabled = false;
            llbHora.Enabled = false;
            btAceptar.Enabled = false;
            tbNombreCampania.Enabled = true;
            btValidarNombre.Visible = true;
            btEditar.Visible = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            if (CondicionesCampaña()) //Se tienen todos los atributos de campaña
            {
                if (MessageBox.Show("¿Da por finalizada la selección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    BotonListo();
                }
            }
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        private void BotonListo()
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void llbHora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaConfigHorario ventanaRangoHorario = new VentanaConfigHorario(TipoEvento.Campania, FachadaEvento, 1);

            if (ventanaRangoHorario.ShowDialog() == DialogResult.OK)
            {
                this.HoraInicio = ventanaRangoHorario.HoraInicio;
                this.HoraFin = ventanaRangoHorario.HoraFin;
                this.ListaDeRangos = ventanaRangoHorario.RangosDeFecha;   
            }

            else
            {
                MessageBox.Show("No ha guardado los cambios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MessageBox.Show(this.HoraInicio.ToString() + " " + this.HoraFin.ToString());
        }
    
    }
}
