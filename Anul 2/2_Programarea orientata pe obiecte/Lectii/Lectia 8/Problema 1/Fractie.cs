using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Fractie
    {
        public double Numarator { get; set; }
        public double Numitor { get; set; }
        public static Fractie operator + (Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numitor + f2.Numarator * f1.Numitor,
                Numitor = f1.Numitor * f2.Numitor
            };
        }
    }
}

