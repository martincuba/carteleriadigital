using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class RangoFecha
    {
        private int RangoFechaId;
        private int EventoId;
        private DateTime aFechaInicio;
        private DateTime aFechaFin;

        /// <summary>
        /// Constructor vacío.
        /// </summary>
        public RangoFecha() { }

        /// <summary>
        /// Constructor de la clase RangoFecha.
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        public RangoFecha(DateTime pFechaInicio, DateTime pFechaFin)
        {
            this.aFechaInicio = pFechaInicio;
            this.aFechaFin = pFechaFin;
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public int RangoFechaID
        {
            get { return this.RangoFechaId; }
            set { this.RangoFechaId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public int EventoID
        {
            get { return this.EventoId; }
            set { this.EventoId = value; }
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
    }
}
