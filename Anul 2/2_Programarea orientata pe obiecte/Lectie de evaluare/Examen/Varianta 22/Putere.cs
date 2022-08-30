using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_22
{
    internal class Putere
    {
        public double Baza { get; set; }
        public double Exponent { get; set; }
        public Putere(double baza, double exponent)
        {
            Baza = baza;
            Exponent = exponent;
        }
        private double Rezultat() => Math.Pow(Baza,Exponent);
        public void Info()
        {
            Console.WriteLine($"{Baza}^{Exponent}={Rezultat()}");
        } 
    }
}
