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
    public partial class VentanaConfigHorario : Form
    {
        private FachadaEvento aFachadaEvento;
        private TimeSpan aHoraInicio;
        private TimeSpan aHoraFin;
        private List<RangoFecha> aRangosFechas = new List<RangoFecha>();
        private DateTime aFechaInicio;
        private DateTime aFechaFin;
        private TipoEvento aTipoEvento;
        private int aCarteleraId;

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int CarteleraId
        {
            get { return this.aCarteleraId; }
            set { this.aCarteleraId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public FachadaEvento FachadaEvento
        {
            get { return this.aFachadaEvento; }
            set { this.aFachadaEvento = value; }
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
        public DateTime FechaInicio
        {
            get { return this.aFechaInicio; }
            set { this.aFechaInicio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public DateTime FechaFin
        {
            get { return this.aFechaFin; }
            set { this.aFechaFin = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public List<RangoFecha> RangosDeFecha
        {
            get { return this.aRangosFechas; }
            set { this.aRangosFechas = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public TipoEvento TipoDeEvento
        {
            get { return this.aTipoEvento; }
            set { this.aTipoEvento = value; }
        }

        public VentanaConfigHorario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor del Formulario
        /// </summary>
        /// <param name="pTipo"></param>
        /// <param name="pFachada"></param>
        /// <param name="pCarte"></param>
        public VentanaConfigHorario(TipoEvento pTipo, FachadaEvento pFachada, int pCarte)
        {
            InitializeComponent();
            TipoDeEvento = pTipo;
            FachadaEvento = pFachada;
            CarteleraId = pCarte;
            dtFechaInicio.MinDate = DateTime.Today;
            dtFechaFin.MinDate = dtFechaInicio.MinDate;
        }

        /// <summary>
        /// Se crea el rango horario del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.HoraInicio = TimeSpan.Parse(mtHoraInicio.Text);
            this.HoraFin = TimeSpan.Parse(mtHoraFin.Text);
            this.gbHorario.Enabled = false;
            this.btAceptar.Enabled = false;
            this.btEditar.Enabled = true;
            this.btValidar.Enabled = true;
            this.gbRangoFecha.Enabled = true;
         /*   if (MessageBox.Show("¿Da por finalizada la acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.HoraInicio = TimeSpan.Parse(mtHoraInicio.Text);
                this.HoraFin = TimeSpan.Parse(mtHoraFin.Text);
                this.Close();
            }*/
        }

        /// <summary>
        /// No guardar rango horario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando el track cambia de valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHoraFin_ValueChanged(object sender, EventArgs e)
        {
            tbHoraFin.Minimum = tbHoraInicio.Value + 1;
            mtHoraFin.Text = DateTime.Today.AddMinutes(tbHoraFin.Value * 10).TimeOfDay.ToString();
            if (tbHoraFin.Value == 144)
            {
                mtHoraFin.Text = DateTime.Today.AddMinutes(1439).TimeOfDay.ToString();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando el track cambia de valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            mtHoraInicio.Text = DateTime.Today.AddMinutes(tbHoraInicio.Value * 10).TimeOfDay.ToString();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia el valor de la hora de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            tbHoraFin.Minimum = tbHoraInicio.Value+1;
            if (TimeSpan.Parse(mtHoraInicio.Text).CompareTo(TimeSpan.Parse(mtHoraFin.Text)) > 0)
            {
                mtHoraFin.Text =  DateTime.Today.AddMinutes((tbHoraInicio.Value * 10)+9).TimeOfDay.ToString();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Se borraran los Rangos de Fecha ya ingresados. \n Continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.gbHorario.Enabled = true;
                this.btAceptar.Enabled = true;
                this.gbRangoFecha.Enabled = false;
                Button[] BotonesADesactivar = { btValidar, btEditar, btAgregar, btEditarFecha, btEditarFecha }; this.EstadoBotones(BotonesADesactivar, false);
                this.RangosDeFecha = new List<RangoFecha>();
                MessageBox.Show(this.RangosDeFecha.Count.ToString());
            }
        }

        /// <summary>
        /// Método para cambiar estado de una lista de botones
        /// </summary>
        /// <param name="pBotones"></param>
        public void EstadoBotones(Button[] pBotones, Boolean pEstado)
        {
            foreach (Button b in pBotones)
            {
                b.Enabled = pEstado;
            }
        }

        /// <summary>
        /// Validar si hay conflictos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btValidar_Click(object sender, EventArgs e)
        {
            this.gbRangoFecha.Enabled = false;
            MessageBox.Show(FachadaEvento.EventosEntreFechas(HoraInicio, HoraFin, new RangoFecha(FechaInicio, FechaFin), TipoDeEvento, CarteleraId).Count.ToString());
            if (FachadaEvento.EventosEntreFechas(HoraInicio, HoraFin, new RangoFecha(FechaInicio, FechaFin), TipoDeEvento, CarteleraId).Count == 0)
            {
                this.btValidar.Enabled = false;
                Button[] BotonesADesactivar = { btAgregar, btEditarFecha }; this.EstadoBotones(BotonesADesactivar, true);
            }
        }

        /// <summary>
        /// Editar el rango de fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditarFecha_Click(object sender, EventArgs e)
        {
            this.btValidar.Enabled = true;
            this.gbRangoFecha.Enabled = true;
            Button[] BotonesADesactivar = { btAgregar, btEditarFecha }; this.EstadoBotones(BotonesADesactivar, false);
        }

        /// <summary>
        /// Agregar rango de fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAgregar_Click(object sender, EventArgs e)
        {
            RangoFecha nuevoRango = new RangoFecha(FechaInicio, FechaFin);
            this.RangosDeFecha.Add(nuevoRango);
            this.gbRangoFecha.Enabled = true;
            this.btValidar.Enabled = true;
            Button[] BotonesADesactivar = { btAgregar, btEditarFecha }; this.EstadoBotones(BotonesADesactivar, false);

            //FIJARME SI NO TIENE CONFLICTO CON EL DE LA MISMA LISTA DE RANGOS NUEVOS
            MessageBox.Show(this.RangosDeFecha.Count.ToString());
        }

        /// <summary>
        /// Cuando cambia el valor de la fecha de fin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            FechaFin = dtFechaFin.Value;
        }

        /// <summary>
        /// Cuando cambia el valor de la fecha de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaInicio.Value.CompareTo(dtFechaFin.Value) > 0)
            {
                dtFechaFin.MinDate = dtFechaInicio.Value;
            }
            FechaInicio = dtFechaInicio.Value;
        }

    }
}
