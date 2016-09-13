using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Inicio
{
    public class RepositorioGenerico<TEntity> where TEntity : class
    {
        internal ContextoCartelera context;
        internal DbSet<TEntity> dbSet;

        /// <summary>
        /// Constructor del Repositorio Generico
        /// </summary>
        /// <param name="pContexto"></param>
        public RepositorioGenerico(ContextoCartelera pContexto)
        {
            this.context = pContexto;
            this.dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Propiedad de solo lectura
        /// </summary>
        public IQueryable<TEntity> Queryable
        {
            get
            {
                return dbSet;
            }
        }

        /// <summary>
        /// Obtener Entidad por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Inserta entidad 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Elimina entidad a partir de un 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Elimina entidad a partir de instancia
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Actualiza entidad
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
