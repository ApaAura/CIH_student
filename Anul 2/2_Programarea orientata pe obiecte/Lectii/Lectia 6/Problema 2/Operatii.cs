using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Operatii
    {
        public static int Suma(int a)
        {
            int suma = 0;
            while (a!=0)
            {
                suma += a % 10;
                a /= 10;
            }
            return suma;
        }
        public static int Suma(string a)
        {
            int suma = 0;
            foreach (char item in a)
            {
                suma += (int)item;
            }
            return suma;
        }
    }
}
