using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Numere
    {   
        public double Suma<T>(T numar1, T numar2)
        {
            return Convert.ToDouble(numar1)+Convert.ToDouble(numar2);
        }
        public double Produs<T>(T numar1, T numar2)
        {
            return Convert.ToDouble(numar1) * Convert.ToDouble(numar2);
        }
    }
}
