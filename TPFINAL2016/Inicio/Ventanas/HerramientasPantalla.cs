using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public static class HerramientasPantalla
    {
        /// <summary>
        /// Metodo para cargar/actualizar un ListBox
        /// </summary>
        /// <param name="pListBox">Objeto a actualizar</param>
        /// <param name="pLista">Elemento a cargar</param>
        public static void CargarListBox(ListBox pListBox, List<string> pLista)
        {
            foreach (string item in pLista)
            {
                pListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualizar List Box - Limpia y recarga
        /// </summary>
        /// <param name="pListBox">ListBox a actualizar</param>
        /// <param name="pLista">Lista nueva a actualizar</param>
        public static void ActualizarListBox(ListBox pListBox, List<string> pLista)
        {
            pListBox.Items.Clear();
            CargarListBox(pListBox, pLista);
        }

        /// <summary>
        /// Actualiza los datos del Binding Navigator
        /// </summary>
        /// <param name="bnActual">Binding Navigator a Actualizar</param>
        /// <param name="plistaRutas">Lista con las actualizaciones</param>
        public static void ActualizarBindingNavigator(BindingNavigator bnActual, List<string> plistaRuta)
        {
            foreach (string Ruta in plistaRuta)
            {
                bnActual.BindingSource.Add(Ruta);
            }
        }

    }
}
