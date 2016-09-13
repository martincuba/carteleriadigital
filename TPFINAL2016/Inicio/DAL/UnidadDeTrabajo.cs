using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class UnidadDeTrabajo : IDisposable
    {
        private ContextoCartelera context = new ContextoCartelera();
        private RepositorioGenerico<Evento> iRepositorioEvento;
        private RepositorioGenerico<RangoFecha> iRepositorioRangoFecha;
        private RepositorioGenerico<Usuario> iRepositorioUsuario;
        private RepositorioGenerico<Media> iRepositorioMedia;
        private RepositorioGenerico<Cartelera> iRepositorioCartelera;


        /// <summary>
        /// Atributo para implementar Singleton.
        /// </summary>
        private static UnidadDeTrabajo instancia = null;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public UnidadDeTrabajo() { }

        /// <summary>
        /// Método de Singleton para obtener la instancia.
        /// </summary>
        /// <returns></returns>
        public static UnidadDeTrabajo GetInstancia()
        {
            if (instancia == null)
                instancia = new UnidadDeTrabajo();

            return instancia;
        }

        /// <summary>
        /// Propiedad de Repositorio de Evento
        /// </summary>
        public RepositorioGenerico<Evento> RepositorioEvento
        {
            get
            {
                if (this.iRepositorioEvento == null)
                {
                    this.iRepositorioEvento = new RepositorioGenerico<Evento>(context);
                }
                return this.iRepositorioEvento;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio de Rango Fecha
        /// </summary>
        public RepositorioGenerico<RangoFecha> RepositorioRangoFecha
        {
            get
            {
                if (this.iRepositorioRangoFecha == null)
                {
                    this.iRepositorioRangoFecha = new RepositorioGenerico<RangoFecha>(context);
                }
                return this.iRepositorioRangoFecha;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio Usuario
        /// </summary>
        public RepositorioGenerico<Usuario> RepositorioUsuario
        {
            get
            {
                if (this.iRepositorioUsuario == null)
                {
                    this.iRepositorioUsuario = new RepositorioGenerico<Usuario>(context);
                }
                return this.iRepositorioUsuario;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio Media
        /// </summary>
        public RepositorioGenerico<Media> RepositorioMedia
        {
            get
            {
                if (this.iRepositorioMedia == null)
                {
                    this.iRepositorioMedia = new RepositorioGenerico<Media>(context);
                }
                return this.iRepositorioMedia;
            }
        }

        /// <summary>
        /// Propiedad de Repositorio Calendario
        /// </summary>
        public RepositorioGenerico<Cartelera> RepositorioCartelera
        {
            get
            {
                if (this.iRepositorioCartelera == null)
                {
                    this.iRepositorioCartelera = new RepositorioGenerico<Cartelera>(context);
                }
                return this.iRepositorioCartelera;
            }
        }
        /// <summary>
        /// Guardar cambios
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// No eliminado
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Eliminar Unidad de trabajo
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
