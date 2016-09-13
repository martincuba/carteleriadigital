using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inicio
{
    public class FachadaMedia
    {
        private UnidadDeTrabajo aUnidadDeTrabajo;

        public FachadaMedia()
        {
            aUnidadDeTrabajo = UnidadDeTrabajo.GetInstancia();
        }

        /// <summary>
        /// Crea Campania
        /// </summary>
        /// <param name="pEvento"></param>
        public void Create(Media pMedia)
        {
            aUnidadDeTrabajo.RepositorioMedia.Insert(pMedia);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Actualiza Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Update(Media pMedia)
        {
            aUnidadDeTrabajo.RepositorioMedia.Update(pMedia);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Eliminar Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Delete(Media pMedia)
        {
            Media mMedia = aUnidadDeTrabajo.RepositorioMedia.GetByID(pMedia.MediaID);
            aUnidadDeTrabajo.RepositorioEvento.Delete(mMedia);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtener todos los Campania
        /// </summary>
        /// <returns></returns>
        public List<Media> GetAll()
        {
            return aUnidadDeTrabajo.RepositorioMedia.Queryable.ToList();
        }

        /// <summary>
        /// Obtener por ID
        /// </summary>
        /// <param name="pUsuarioId"></param>
        /// <returns></returns>
        public Media GetById(int pMediaId)
        {
            return aUnidadDeTrabajo.RepositorioMedia.GetByID(pMediaId);
        }

        /// <summary>
        /// Obtiene un elemento por la posición indicada.
        /// </summary>
        /// <param name="pListaMedia"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Media ObtenerPorPosicion(List<Media> pListaMedia,int pos)
        {
            Media iMedia = new Media();
            if (pListaMedia.Count < pos)
            {
                iMedia = pListaMedia.Last();
            }
            else
            {
                foreach (Media aMedia in pListaMedia)
                {
                    if (aMedia.Posicion == pos)
                    {
                        iMedia = aMedia;
                    }
                }
            }
            return iMedia;
        }
    }
}
