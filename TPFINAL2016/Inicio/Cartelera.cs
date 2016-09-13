using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class Cartelera
    {
        private int aCarteleraId;
        private string aNombre;
        private List<Evento> aListaEventos = new List<Evento>();

        /// <summary>
        /// Constructor vacío.
        /// </summary>
        public Cartelera() { }

        /// <summary>
        /// Sobrecarga de constructor.
        /// </summary>
        /// <param name="pNombre">Nombre de la Cartelera</param>
        public Cartelera(string pNombre)
        {
            this.aNombre = pNombre;
            this.aListaEventos = new List<Evento>();
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int CarteleraID
        {
            get { return this.aCarteleraId; }
            set { this.aCarteleraId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public string Nombre
        {
            get { return this.aNombre; }
            set { this.aNombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public virtual List<Evento> ListaEventos
        {
            get { return this.aListaEventos; }
            set { this.aListaEventos = value; }
        }
    }
}
