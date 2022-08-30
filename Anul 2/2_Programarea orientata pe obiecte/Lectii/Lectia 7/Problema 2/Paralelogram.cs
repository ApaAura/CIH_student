using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Paralelogram : Triad
    {
        public double Aria() =>N1*N3;

        public double Perimetru() =>(N1+N2)*2;
        public void Afisare()
        {
            base.Afisare();
            Console.WriteLine($"Perimetrul : {Perimetru()}\nAria : {Aria()}");
        }
    }
}
