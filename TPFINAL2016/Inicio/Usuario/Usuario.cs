using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class Usuario
    {
        private int usuarioId;
        private string aNombre;
        private string aClave;
        private TipoUsuario aTipoUsuario;

        /// <summary>
        /// Constructor de clase
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pClave"></param>
        /// <param name="pTipoUsuario"></param>
        public Usuario(string pNombre, string pClave, TipoUsuario pTipoUsuario)
        {
            this.aNombre = pNombre;
            this.aClave = pClave;
            this.aTipoUsuario = pTipoUsuario;
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
        public string Clave
        {
            get { return this.aClave; }
            set { this.aClave = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public TipoUsuario TipoUsuario
        {
            get { return this.aTipoUsuario; }
            set { this.aTipoUsuario = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int UsuarioID
        {
            get { return this.usuarioId; }
            set { this.usuarioId = value; }
        }
    }
}
