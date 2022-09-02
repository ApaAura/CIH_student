using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Cerc : IFiguraGeometrica
    {
        public double Raza { get; set; }
        public double Aria()
        {
            return Math.PI * (Raza * Raza);
        }
        public double Perimetru()
        {
            return 2*Math.PI * Raza;
        }
    }
}
