using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class FachadaUsuario
    {
        private UnidadDeTrabajo aUnidadDeTrabajo;

        public FachadaUsuario()
        {
            aUnidadDeTrabajo = UnidadDeTrabajo.GetInstancia();
        }

        /// <summary>
        /// Crea Campania
        /// </summary>
        /// <param name="pEvento"></param>
        public void Create(Usuario pUsuario)
        {
            aUnidadDeTrabajo.RepositorioUsuario.Insert(pUsuario);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Actualiza Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Update(Usuario pUsuario)
        {
            aUnidadDeTrabajo.RepositorioUsuario.Update(pUsuario);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Eliminar Campania
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Delete(Usuario pUsuario)
        {
            Usuario mUsuario = aUnidadDeTrabajo.RepositorioUsuario.GetByID(pUsuario);
            aUnidadDeTrabajo.RepositorioEvento.Delete(mUsuario);
            aUnidadDeTrabajo.Save();
        }

        /// <summary>
        /// Obtener todos los Campania
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetAll()
        {
            return aUnidadDeTrabajo.RepositorioUsuario.Queryable.ToList();
        }

        /// <summary>
        /// Obtener por ID
        /// </summary>
        /// <param name="pUsuarioId"></param>
        /// <returns></returns>
        public Usuario GetById(int pUsuarioId)
        {
            return aUnidadDeTrabajo.RepositorioUsuario.GetByID(pUsuarioId);
        }

        public int UsuarioID
        {
            get { return this.UsuarioID; }
            set { this.UsuarioID = value; }
        }

    }

}
