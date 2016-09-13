using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class OrdenarPorPosicion : IComparer<Media>
    {
        /// <summary>
        /// Compara por posición de Media.
        /// </summary>
        /// <param name="pMedia1"></param>
        /// <param name="pMedia2"></param>
        /// <returns></returns>
        public int Compare(Media pMedia1, Media pMedia2)
        {
            
            if ((pMedia1.Posicion - pMedia2.Posicion) < 0)
                return -1;
            else if ((pMedia1.Posicion - pMedia2.Posicion) > 0)
                return 1;
            else
                return 0;
        }
    }
}
