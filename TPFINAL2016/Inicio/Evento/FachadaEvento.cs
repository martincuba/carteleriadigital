using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class FachadaEvento
    {
        private UnidadDeTrabajo aUnidadDeTrabajo;

        public FachadaEvento()
        {
            aUnidadDeTrabajo = UnidadDeTrabajo.GetInstancia();
        }

        /// <summary>
        /// Crea Campania
        /// </summary>
        /// <param name="pEvento"></param>
        public void Create(Evento pEvento)
        {
            aUnidadDeTrabajo.RepositorioEvento.Insert(pEvento);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Actualiza Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Update(Evento pEvento)
        {
            aUnidadDeTrabajo.RepositorioEvento.Update(pEvento);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Eliminar Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Delete(Evento pEvento)
        {
            Evento mEvento = aUnidadDeTrabajo.RepositorioEvento.GetByID(pEvento.EventoID);
            aUnidadDeTrabajo.RepositorioEvento.Delete(mEvento);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtener todos los Campania
        /// </summary>
        /// <returns></returns>
        public List<Evento> GetAll()
        {
            return aUnidadDeTrabajo.RepositorioEvento.Queryable.ToList();
        }

        /// <summary>
        /// Obtener por ID
        /// </summary>
        /// <param name="pUsuarioId"></param>
        /// <returns></returns>
        public Evento GetById(int pEventoId)
        {
            return aUnidadDeTrabajo.RepositorioEvento.GetByID(pEventoId);
        }
        
        /// <summary>
        /// Obtener una lista de todos los eventos de un tipo particular 
        /// </summary>
        /// <param name="pTipoEvento"></param>
        /// <returns></returns>
        public List<Evento> ObtenerEventosDeCartelera(TipoEvento pTipoEvento, int pCarteleraId)
        {
            return aUnidadDeTrabajo.RepositorioEvento.Queryable.Where(Evento => ((Evento.TipoEvento==pTipoEvento)) && (Evento.CarteleraID == pCarteleraId)).ToList();
        }

        /// <summary>
        /// Verdadero si hay conflicto entre los horarios
        /// </summary>
        /// <returns></returns>
        public bool ConflictoHorario(TimeSpan pHoraInicio, TimeSpan pHoraFin, TimeSpan pHoraInicioNuevo, TimeSpan phoraFinNuevo)
        {
            bool conflicto = false;
            if ((pHoraInicio.TotalMinutes == pHoraInicioNuevo.TotalMinutes) || (pHoraFin.TotalMinutes == phoraFinNuevo.TotalMinutes))
                //if ((pHoraInicio.TimeOfDay.TotalMinutes == pHoraInicioNuevo.TimeOfDay.TotalMinutes) || (pHoraFin.TimeOfDay.TotalMinutes == phoraFinNuevo.TimeOfDay.TotalMinutes)) //Inicio o Fin coinciden en ambos intervalos
            {
                conflicto = true;
            }
            else
            {
                if ((pHoraInicio.TotalMinutes < pHoraInicioNuevo.TotalMinutes) && (pHoraFin.TotalMinutes > pHoraInicioNuevo.TotalMinutes))
                //if ((pHoraInicio.TimeOfDay.TotalMinutes < pHoraInicioNuevo.TimeOfDay.TotalMinutes) && (pHoraFin.TimeOfDay.TotalMinutes > pHoraInicioNuevo.TimeOfDay.TotalMinutes))//Conflicto despues de la hora de inicio del eIntervalo y antes del fin del mismo
                {
                    conflicto = true;
                }
                else
                {
                    if ((pHoraInicio.TotalMinutes > pHoraInicioNuevo.TotalMinutes) && (pHoraInicio.TotalMinutes < phoraFinNuevo.TotalMinutes))
                    //if ((pHoraInicio.TimeOfDay.TotalMinutes > pHoraInicioNuevo.TimeOfDay.TotalMinutes) && (pHoraInicio.TimeOfDay.TotalMinutes < phoraFinNuevo.TimeOfDay.TotalMinutes)) //Conflicto antes de la hora de inicio del eIntervalo y antes del fin del mismo
                    {
                        conflicto = true;
                    }
                }
            }
            return conflicto;
        }

        /// <summary>
        /// Verdadero si hay conflicto entre las Fechas
        /// </summary>
        /// <returns></returns>
        public bool ConflictoFecha(DateTime pFechaInicio, DateTime pFechaFin, DateTime pFechanicioNuevo, DateTime pFechaFinNuevo)
        {
            bool conflicto = false;
            if ((pFechaInicio.CompareTo(pFechanicioNuevo) == 0) || (pFechaFin.CompareTo( pFechaFinNuevo)==0)) //Inicio o Fin coinciden en ambos intervalos
            {
                conflicto = true;
            }
            else
            {
                if ((pFechaInicio.CompareTo(pFechanicioNuevo) < 0) && (pFechaFin.CompareTo(pFechanicioNuevo) > 0))//Conflicto despues de inicio del eIntervalo y antes del fin del mismo
                {
                    conflicto = true;
                }
                else
                {
                    if ((pFechaInicio.CompareTo(pFechanicioNuevo) > 0) && (pFechaInicio.CompareTo(pFechaFinNuevo) < 0)) //Conflicto antes de inicio del eIntervalo y antes del fin del mismo
                    {
                        conflicto = true;
                    }
                }
            }
            return conflicto;
        }

        /// <summary>
        /// Verdadero si hay conflicto entre el rango y al menos uno de los rangos de la lista
        /// </summary>
        /// <param name="pListaRangos"></param>
        /// <param name="pRango"></param>
        /// <returns></returns>
        public bool ConflictoListaFechas(List<RangoFecha> pListaRangos, RangoFecha pRango )
        {
            bool conflicto = false;
            foreach (RangoFecha elRango in pListaRangos)
            {
                if (ConflictoFecha(elRango.FechaInicio, elRango.FechaFin, pRango.FechaInicio,pRango.FechaFin))
                {
                    conflicto = true;
                }
            }
            return conflicto;
        }

        /// <summary>
        /// Obtiene la lista de eventos de un tipo determinado, con fechas y horas en conflictos
        /// </summary>
        /// <param name="pRangoFecha"></param>
        /// <returns></returns>
        public List<Evento> EventosEntreFechas(TimeSpan pHoraInicio, TimeSpan pHoraFin, RangoFecha pRangoFecha, TipoEvento pTipoEvento, int pCarteleraId)
        {
            /*List<Evento> iListaEventos = aUnidadDeTrabajo.RepositorioEvento.Queryable.Where((Evento =>
                                                                                  (Evento.TipoEvento == pTipoEvento) && 
                                                                                  (ConflictoHorario(Evento.HoraInicio, Evento.HoraFin, pHoraInicio, pHoraFin)) &&
                                                                                  (ConflictoListaFechas(Evento.ListaRangoFecha, pRangoFecha)))
                                                                                  ).ToList();*/

            List<Evento> iListaEventos = ObtenerEventosDeCartelera(pTipoEvento, pCarteleraId);
            List<Evento> iListaEventosConflictivos = new List<Evento>();
            foreach (Evento iEvento in iListaEventos)
            {
                if ((ConflictoHorario(iEvento.HoraInicio, iEvento.HoraFin, pHoraInicio, pHoraFin)) && ConflictoListaFechas(iEvento.ListaRangoFecha, pRangoFecha))
                {
                    iListaEventosConflictivos.Add(iEvento);
                }
            }
            return iListaEventosConflictivos;
        }

        /// <summary>
        /// Verdadero si ambos nombres son iguales luego de quitarles los espacios.
        /// </summary>
        /// <param name="pNombreGuardado">Nombre inicialmente guardado</param>
        /// <param name="pNombreNuevo">Nombre a comprobar si puede ser guardado</param>
        /// <returns></returns>
        public bool ConflictoNombres(string pNombreGuardado, string pNombreNuevo)
        {
            bool conflicto = false;
            if (pNombreGuardado.Replace(" ", "").CompareTo(pNombreNuevo.Replace(" ", "")) == 0)
            {
                conflicto = true;
            }
            return conflicto;
        }

        /// <summary>
        /// Verdadero si es igual a algun nombre ya almacenado.
        /// </summary>
        /// <param name="pNombreNuevo">Nombre nuevo que se quiere validar</param>
        /// <returns></returns>
        public bool ConflictoNombresEvento(string pNombreNuevo, int carteleraId)
        {
            bool conflicto = false;
            List<string> ListaNombres = this.aUnidadDeTrabajo.RepositorioEvento.Queryable.Where(Evento => Evento.CarteleraID==carteleraId).Select(Evento => Evento.Nombre).ToList();
            foreach (string aNombre in ListaNombres)
            {
                if (ConflictoNombres(aNombre, pNombreNuevo))
                {
                    conflicto = true;
                }
            }

            return conflicto;
        }
    }
}
