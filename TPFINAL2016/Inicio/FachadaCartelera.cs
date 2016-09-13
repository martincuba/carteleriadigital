using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
   public class FachadaCartelera
    {
        private UnidadDeTrabajo aUnidadDeTrabajo;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public FachadaCartelera()
        {
            aUnidadDeTrabajo = UnidadDeTrabajo.GetInstancia();
        }

        /// <summary>
        /// Crea Campania
        /// </summary>
        /// <param name="pEvento"></param>
        public void Create(Cartelera pCartelera)
        {
            aUnidadDeTrabajo.RepositorioCartelera.Insert(pCartelera);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Actualiza Calendario
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Update(Cartelera pCartelera)
        {
            aUnidadDeTrabajo.RepositorioCartelera.Update(pCartelera);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Eliminar Calendario
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Delete(Cartelera pCartelera)
        {
            Cartelera mCartelera = aUnidadDeTrabajo.RepositorioCartelera.GetByID(pCartelera.CarteleraID);
            aUnidadDeTrabajo.RepositorioCartelera.Delete(mCartelera);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtener todos los Calendario
        /// </summary>
        /// <returns></returns>
        public List<Cartelera> GetAll()
        {
            return aUnidadDeTrabajo.RepositorioCartelera.Queryable.ToList();
        }

        /// <summary>
        /// Obtener por ID
        /// </summary>
        /// <param name="pUsuarioId"></param>
        /// <returns></returns>
        public Cartelera GetById(int pCarteleraId)
        {
            return aUnidadDeTrabajo.RepositorioCartelera.GetByID(pCarteleraId);
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
            if (pNombreGuardado.Replace(" ", "").CompareTo(pNombreNuevo.Replace(" ", "")) ==0)
            {
                conflicto = true;
            }
            return conflicto;
        }

        /// <summary>
        /// Verdadero si es igual a algun nombre ya almacenado.
        /// </summary>
        /// <param name="pNombreNuevo"></param>
        /// <returns></returns>
        public bool ConflictoNombresCartelera(string pNombreNuevo)
        {
            bool conflicto = false;
            List<string> ListaNombres = this.aUnidadDeTrabajo.RepositorioCartelera.Queryable.Select(Cartelera => Cartelera.Nombre).ToList();
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
