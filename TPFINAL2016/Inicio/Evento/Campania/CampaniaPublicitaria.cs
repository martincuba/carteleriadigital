using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class CampaniaPublicitaria : Evento
    {
        private List<IMedia> aListaMedia = new List<IMedia>();

        public CampaniaPublicitaria () { }

        /// <summary>
        /// Constructor de la clase Campania.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pActivo"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pListaRangoFecha"></param>
        public CampaniaPublicitaria(string pNombre, bool pActivo, TimeSpan pHoraInicio, TimeSpan pHoraFin, List<RangoFecha> pListaRangoFecha)
        {
            this.Nombre = pNombre;
            this.Activo = pActivo;
            this.HoraInicio = pHoraInicio;
            this.HoraFin = pHoraFin;
            this.ListaRangoFecha = pListaRangoFecha;
            this.TipoEvento = TipoEvento.Campania;
        }

        /// <summary>
        /// Constructor de la clase Evento sin RangoFecha.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pActivo"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        public CampaniaPublicitaria(string pNombre, bool pActivo, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            this.Nombre = pNombre;
            this.Activo = pActivo;
            this.HoraInicio = pHoraInicio;
            this.HoraFin = pHoraFin;
            this.ListaRangoFecha = new List<RangoFecha>();
            this.TipoEvento = TipoEvento.Campania;
        }


        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public virtual List<IMedia> ListaMedia
        {
            get { return this.aListaMedia; }
            set { this.aListaMedia = value; }
        }

    }
}
