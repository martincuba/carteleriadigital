using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public interface IMedia
    {
        Media Anterior();
        Media Siguiente();
    }
}
