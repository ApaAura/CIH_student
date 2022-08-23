using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Operatii
    {
        public static double Calculeaza(double a)
        {
            return Math.Pow(a, 2);
        }
        public static double Calculeaza(double a, double b)
        {
            return a+b;
        }
        public static double Calculeaza(double a, double b, char c)
        {
            double res = 0;
            switch(c)
            {
                case '+':res = Calculeaza(a,b); break;
                case '-':res = Calculeaza(a, -1 * b); break;
                case '*':res = a * b; break;
                case '/': res = a / b; break;
            }
            return res;
        }
    }
}
