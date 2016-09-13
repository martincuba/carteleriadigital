using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class Banner : Evento
    {
        public Banner(){}

        /// <summary>
        /// Constructor de la clase Banner.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pActivo"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pListaRangoFecha"></param>
        public Banner(string pNombre, bool pActivo, TimeSpan pHoraInicio, TimeSpan pHoraFin, List<RangoFecha> pListaRangoFecha)
        {
            this.Nombre = pNombre;
            this.Activo = pActivo;
            this.HoraInicio = pHoraInicio;
            this.HoraFin = pHoraFin;
            this.ListaRangoFecha = pListaRangoFecha;
            this.TipoEvento = TipoEvento.Banner;
        }

        /// <summary>
        /// Constructor de la clase Banner sin RangoFecha.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pActivo"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        public Banner(string pNombre, bool pActivo, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            this.Nombre = pNombre;
            this.Activo = pActivo;
            this.HoraInicio = pHoraInicio;
            this.HoraFin = pHoraFin;
            this.ListaRangoFecha = new List<RangoFecha>();
            this.TipoEvento = TipoEvento.Banner;
        }


    }
}
