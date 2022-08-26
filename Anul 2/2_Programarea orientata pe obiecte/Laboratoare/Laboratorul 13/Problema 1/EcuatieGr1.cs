using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class EcuatieGr1
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public EcuatieGr1(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double X()
        {
            double x = 0;
            x = (C - B) / A;
            return x;
        }
        public void Info()
        {
            Console.WriteLine($"{A}x+{B}={C}");
            Console.WriteLine($"X={X():F3}");
        }
    }
}
