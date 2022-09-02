using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Patrat : IFiguraGeometrica
    {
        public double Latura { get; set; }
        public double Aria()
        {
            return Latura * Latura;
        }
        public double Perimetru()
        {
            return Latura * 4;
        }
    }
}
