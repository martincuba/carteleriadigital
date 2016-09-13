using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inicio
{
    public class Media : IMedia
    {
        private int MediaId;
        private string aRutaArch;
        private int aPosicion;
        private bool aActiva;
        private int aDuracion;
        private int EventoId;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Media() { }

        /// <summary>
        /// Constructor de la Clase Archivo
        /// </summary>
        /// <param name="pRutaEntera"></param>
        public Media(string pRutaEntera, int pPos, int pDuracion) //tArchivo pTipo
        {
            this.aRutaArch = pRutaEntera;
            this.aPosicion = pPos;
            this.aDuracion = pDuracion;
        }

        /// <summary>
        /// Sobrecarga constructor-
        /// </summary>
        /// <param name="pRutaEntera"></param>
        /// <param name="pPos"></param>
        public Media(string pRutaEntera, int pPos)
        {
            this.aRutaArch = pRutaEntera;
            this.aPosicion = pPos;
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int MediaID
        {
            get { return MediaId; }
            set { MediaId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public string RutaArchivo
        {
            get { return aRutaArch; }
            set { aRutaArch = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int Posicion
        {
            get { return aPosicion; }
            set { aPosicion = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public bool Activa
        {
            get { return aActiva; }
            set { aActiva = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public int Duracion
        {
            get { return aDuracion; }
            set { aDuracion = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
       public int EventoID
        {
            get { return EventoId; }
            set { EventoId = value; }
        }

        //Metodos de la interface. VER
        public Media Anterior() { return new Media(); }
        public Media Siguiente() { return new Media(); }
    }
}
