using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cancion.modelo
{
    public class Cancion
    {
        [key]
        public string Titulo { get; set; }
        [Requerir]
        public string Autor { get; set; }
        [Requerir]
        public string Letra { get; set; }
        [Requerir]
        public string EnlaceYT { get; set; }
    }
}
