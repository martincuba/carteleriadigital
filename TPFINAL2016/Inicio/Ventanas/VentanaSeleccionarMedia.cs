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
    public partial class VentanaSeleccionarMedia : Form
    {
        private List<Media> aListaMedia;
        private FachadaMedia aFachadaMedia;
        private Media aMediaActual;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pListaMedia"></param>
        public VentanaSeleccionarMedia(List<Media> pListaMedia, FachadaMedia pFachadaMedia)
        {
            InitializeComponent();
            this.aFachadaMedia = pFachadaMedia;
            this.aListaMedia = pListaMedia;
            if (ListaMedia.Count > 0)
            {
                MediaActual = ListaMedia.First();
                SeleccionNoVacia();
            }

        }

        /// <summary>
        /// Propieda de Lectura y Escritura.
        /// </summary>
        public List<Media> ListaMedia
        {
            get
            {
                return (aListaMedia);
            }
            set { this.aListaMedia = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public FachadaMedia FachadaMedia
        {
            get { return this.aFachadaMedia; }
            set { this.aFachadaMedia = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public Media MediaActual
        {
            get { return this.aMediaActual; }
            set { this.aMediaActual = value; }
        }

        /// <summary>
        /// Confirma la selección. Se debe seleccionar al menos un elemento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btListo_Click(object sender, EventArgs e)
        {
            if (ListaMedia.Count > 0) //Al menos un Archivo Seleccionado
            {
                if (MessageBox.Show("¿Da por finalizada la selección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BotonListo();
                }
            }

            else { MessageBox.Show("No ha seleccionado ningún archivo"); }
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        private void BotonListo()
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Activa los elementos por tener media seleccionada
        /// </summary>
        private void SeleccionNoVacia()
        {
            btVistaPrevia.Visible = true;
            gbUbicacionSecuencia.Visible = true;
            btEliminar.Enabled = true;
            btSiguiente.Enabled = true;
            btAtras.Enabled = true;
            pbImagen.Image = Image.FromFile(this.MediaActual.RutaArchivo);
            ActualizarMediaActual();
        }

        /// <summary>
        /// Oculta los botones por tener la lista de seleciones vacia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionVacia(object sender, EventArgs e)
        {
            gbUbicacionSecuencia.Visible = false;
            btVistaPrevia.Visible = false;
            btEliminar.Enabled = false;
            btSiguiente.Enabled = false;
            btAtras.Enabled = false;
            btExaminar_Click(sender, e);
        }

        /// <summary>
        /// Abre la ventana "Vista Previa"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btVistaPrevia_Click(object sender, EventArgs e)
        {
            VentanaVistaPrevia ventanaVistaPrevia = new VentanaVistaPrevia(ListaMedia);
            ventanaVistaPrevia.ShowDialog();
        }

        /// <summary>
        /// Convierte una lista de rutas (string) en objetos Media.
        /// </summary>
        /// <param name="ListaRutaMedia"></param>
        /// <returns></returns>
        public List<Media> ConvertirEnMedia(List<string> ListaRutaMedia)
        {
            int cont = 1;
            List<Media> iListaMedia = new List<Media>();
            foreach (string ruta in ListaRutaMedia)
            {
                Media iMedia = new Media(ruta, cont,2);
                iListaMedia.Add(iMedia);
                cont++;
            }
            return iListaMedia;
        }

        /// <summary>
        /// Abre la ventana Examinar y permite seleccionar archivos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExaminar_Click(object sender, EventArgs e)
        {
            if (fdImagen.ShowDialog() == DialogResult.OK)
            {
                this.ListaMedia= AddLista(ListaMedia,  this.ConvertirEnMedia(fdImagen.FileNames.ToList<string>()));
                this.MediaActual = ListaMedia.First();
                fdImagen.Dispose();
                ActualizarPosicionesMedia(ListaMedia);
                ActualizarMediaActual(); ;
                if (ListaMedia.Count > 0)
                {
                    this.SeleccionNoVacia();
                }
                

            }
        }

        /// <summary>
        /// Agrega los elementos de una lista, a los de otra.
        /// </summary>
        /// <param name="pListaOriginal">Lista Original</param>
        /// <param name="pListaNueva">Lista Nueva</param>
        /// <returns></returns>
        public List<Media> AddLista(List<Media> pListaOriginal, List<Media> pListaNueva)
        {           
            foreach (Media media in pListaNueva)
            {
                pListaOriginal.Add(media);
            }
            return pListaOriginal;
        }

        /// <summary>
        /// Elimina Media actual seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (ListaMedia.Count < 2)
            {
                ListaMedia.Remove(MediaActual);
                this.SeleccionVacia(sender, e);
            }

            else
            {
                ListaMedia.Remove(MediaActual);
                this.ActualizarPosicionesMedia(ListaMedia);
                MediaActual = FachadaMedia.ObtenerPorPosicion(ListaMedia, MediaActual.Posicion);
                pbImagen.Image = Image.FromFile(this.MediaActual.RutaArchivo);
                ActualizarMediaActual(); 

            }
        }

        /// <summary>
        /// Actualiza las posiciones de toda la lista.
        /// </summary>
        /// <param name="pListaMedia">Lista a actualizar</param>
        /// <returns></returns>
        public List<Media> ActualizarPosicionesMedia(List<Media> pListaMedia)
        {
            int cont = 1;
            foreach (Media mMedia in pListaMedia)
            {
                mMedia.Posicion = cont;
                cont++;
            }
            return pListaMedia;

        }

        /// <summary>
        /// Avanza un lugar en la lista de media.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if (this.MediaActual == this.ListaMedia.Last())
            {
                this.MediaActual = ListaMedia.First();
            }
            else
            {
                MediaActual = FachadaMedia.ObtenerPorPosicion(ListaMedia, MediaActual.Posicion + 1);
            }
            pbImagen.Image = Image.FromFile(this.MediaActual.RutaArchivo);
            ActualizarMediaActual();

        }

        /// <summary>
        /// Retrocede un lugar en la lista de media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAtras_Click(object sender, EventArgs e)
        {
            if (this.MediaActual == this.ListaMedia.First())
            {
                this.MediaActual = ListaMedia.Last();
            }
            else
            {
                MediaActual = FachadaMedia.ObtenerPorPosicion(ListaMedia, MediaActual.Posicion - 1);
            }
            pbImagen.Image = Image.FromFile(this.MediaActual.RutaArchivo);
            ActualizarMediaActual();

        }

        /// <summary>
        /// Retrocede en una posicion a la media actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void btRetroceder_Click(object sender, EventArgs e)
       {
            if (this.MediaActual.Posicion > 1)
            {
                Media iMediaAnterior = FachadaMedia.ObtenerPorPosicion(ListaMedia, MediaActual.Posicion - 1);
                ListaMedia.Remove(MediaActual);
                ListaMedia.Remove(iMediaAnterior);
                MediaActual.Posicion--;
                iMediaAnterior.Posicion++;
                ListaMedia.Add(MediaActual);
                ListaMedia.Add(iMediaAnterior);
                ListaMedia.Sort(new OrdenarPorPosicion());
                ActualizarMediaActual();
            }
        }


        /// <summary>
        /// Adelanta una posicion a la media actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdelantar_Click(object sender, EventArgs e)
        {
            if (this.MediaActual.Posicion < this.ListaMedia.Count)
            {
                Media iMediaPosterior = FachadaMedia.ObtenerPorPosicion(ListaMedia, MediaActual.Posicion + 1);
                ListaMedia.Remove(MediaActual);
                ListaMedia.Remove(iMediaPosterior);
                MediaActual.Posicion++;
                iMediaPosterior.Posicion--;
                ListaMedia.Add(MediaActual);
                ListaMedia.Add(iMediaPosterior);
                ListaMedia.Sort(new OrdenarPorPosicion());
                ActualizarMediaActual();
            }
        }

        /// <summary>
        /// Actualiza los valores de duracion y posicion de la media actual en la pantalla.
        /// </summary>
        private void ActualizarMediaActual()
        {
            lbPosicion.Text = MediaActual.Posicion.ToString() + " de " + ListaMedia.Count.ToString();
            numDuracion.Value = MediaActual.Duracion;
        }

        private void numDuracion_ValueChanged(object sender, EventArgs e)
        {
            MediaActual.Duracion = int.Parse(numDuracion.Value.ToString());
        }
    }
    
}
