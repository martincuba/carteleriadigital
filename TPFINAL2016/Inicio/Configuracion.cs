using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inicio
{
    public static class Configuracion
    {
        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public static string DirectorioBase
        {
            get { return @"C:\Users\"; }
        }

        /// <summary>
        /// Método para copiar archivos a un nuevo destino
        /// </summary>
        /// <param name="pListaArchivos">Lista de archivos a copiar</param>
        public static List<Media> CopiarArchivos(List<string> pListaArchivos, string pRutaDestino)
        {
            string rutaCarpetaOrigen;
            string nombreArchivo;
            List<Media> nListaArchivo = new List<Media>();

            foreach (string rutaArchivo in pListaArchivos)
            {
                rutaCarpetaOrigen = Path.GetDirectoryName(rutaArchivo);
                nombreArchivo = Path.GetFileName(rutaArchivo);

                if (Directory.Exists(rutaCarpetaOrigen)) //- Verificar si existe la ruta
                {
                    string archivo = Path.Combine(rutaCarpetaOrigen, nombreArchivo);
                    string destino = Path.Combine(pRutaDestino, nombreArchivo);

                    File.Copy(archivo, destino, true); //true-Reemplaza el archivo si ya existe ----destino

                    Media nArchivo = new Media(destino, nListaArchivo.Count + 1);
                    nListaArchivo.Add(nArchivo);
                }
            }

            return (nListaArchivo);
        }  //NO TOCAR!!!

        /// <summary>
        /// Metodo para crear un Directorio
        /// </summary>
        /// <param name="pNombreCarpeta">Nombre del Directorio</param>
        /// <returns>Devuelve ruta completa</returns>
        public static string CrearDirectorio(string pNombreCarpeta)
        {
            string RutaCarpeta = Path.Combine(DirectorioBase, pNombreCarpeta);
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
