using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public abstract class Evento
    {
        private int eventoId;
        private int carteleraId;
        private string aNombre;
        private bool aActivo;
        private TimeSpan aHoraInicio;
        private TimeSpan aHoraFin;
        private TipoEvento aTipoEvento;
        private List<RangoFecha> aListaRangoFecha = new List<RangoFecha>();



        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int EventoID
        {
            get { return this.eventoId; }
            set { this.eventoId = value; }
        }

        public int CarteleraID
        {
            get { return this.carteleraId; }
            set { this.carteleraId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public string Nombre
        {
            get { return this.aNombre; }
            set { this.aNombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public bool Activo
        {
            get { return this.aActivo; }
            set { this.aActivo = value; }
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
        public TipoEvento TipoEvento
        {
            get { return this.aTipoEvento; }
            set { this.aTipoEvento = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public virtual List<RangoFecha> ListaRangoFecha
        {
            get { return this.aListaRangoFecha; }
            set { this.aListaRangoFecha = value; }
        }
    }
}
