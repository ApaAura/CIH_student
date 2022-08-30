using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Trapez_isoscel :Triad
    {
        public double Latura()
        {
            double S1 = (N1 + N2) / 2;
            return Math.Sqrt(Math.Pow(S1, 2) + Math.Pow(N3, 2));
        }
        public double Perimetrul() =>N1+N2+(Latura()*2);
        public double Aria() =>((N1-N2)/2)*N3;
        public void Afisare()
        {
            base.Afisare();
            Console.WriteLine($"Perimetrul : {Perimetrul()}\nAria : {Aria()}");
        }
    }
}
