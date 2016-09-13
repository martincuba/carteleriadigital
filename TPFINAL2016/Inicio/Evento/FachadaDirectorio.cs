using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inicio
{
    public static class FachadaDirectorio
    {
        /// <summary>
        /// Metodo para crear un Directorio
        /// </summary>
        /// <param name="pNombreCarpeta">Nombre del Directorio</param>
        /// <returns>Devuelve ruta completa</returns>
        public static string CrearDirectorio(string pNombreCarpeta)
        {
            string RutaCarpeta = Path.Combine(Configuracion.DirectorioBase, pNombreCarpeta);
            Directory.CreateDirectory(RutaCarpeta);

            return RutaCarpeta;
        }  //NO TOCAR!!!

        /// <summary>
        /// Verifica si es invalido como nombre de directorio el string.
        /// </summary>
        /// <param name="nombreDirectorio">Nombre de directorio a verificar</param>
        /// <returns></returns>
        public static bool NombreDirectorioInvalido(string nombreDirectorio)
        {
            bool resultado = false;
            string caracteresInvalidos = "^[^/./\\:*?\"<>|]+$";
            for (int pos = 0; pos < caracteresInvalidos.Length; pos++)
            {
                if (nombreDirectorio.Contains(caracteresInvalidos[pos]))
                    resultado = true;
            }
            return resultado;
        }
    }
}
