using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Libro
    {
        public string Titulo { get; set; }
        public int IDAutor { get; set; }
        public int FechaPublicacion { get; set; } // Year
        public int Ventas { get; set; } //Millions
    }
}
