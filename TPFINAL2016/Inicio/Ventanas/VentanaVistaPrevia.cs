using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class VentanaVistaPrevia : Form
    {
        private List<Media> aImagenes;
        private int cont = 0;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="pListaImagenes"></param>
        public VentanaVistaPrevia(List<Media> pListaImagenes)
        {
            this.aImagenes = pListaImagenes;
            InitializeComponent();
        }

        private void VentanaVistaPrevia_Load(object sender, EventArgs e)
        {
            TimmerPaso.Enabled = true;

        }

        private void TimmerPaso_Tick(object sender, EventArgs e)
        {
            TimmerPaso.Interval = aImagenes[cont].Duracion*1000;
            pbImagenes.Image = Image.FromFile(aImagenes[cont].RutaArchivo);
            if (cont == aImagenes.Count - 1)
            {
                cont = 0;
            }
            else
            {
                cont++;
            }
        }
    }
}
