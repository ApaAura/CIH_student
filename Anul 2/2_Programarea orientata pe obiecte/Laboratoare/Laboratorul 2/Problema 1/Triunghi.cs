using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Triunghi
    {
        public double catetaA { get; set; }
        public double catetaB { get; set; }
        public Triunghi()
        {
            catetaA = 0;
            catetaB = 0;
        }
        public Triunghi(double catetaA, double catetaB)
        {
            this.catetaA = catetaA;
            this.catetaB = catetaB;
        }
        public double Perimetru => catetaA + catetaB + Ipotenuza;
        public double Aria => (catetaA + catetaB)/2;
        private double Ipotenuza => Math.Sqrt(Math.Pow(catetaA,2)+Math.Pow(catetaB,2));
        public void Citire()
        {
            Console.Write("Dimensiunea cateta1: ");
            catetaA = int.Parse(Console.ReadLine());
            Console.Write("Dimensiune cateta2: ");
            catetaB=int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Dimensiunile triunghilui. \nCateta 1 = {catetaA}\nCateta 2 = {catetaA}\nIpotenuza = {Ipotenuza}");
            Console.WriteLine($"Perimetrul triunghiului: {Perimetru}");
            Console.WriteLine($"Aria triunghiului {Aria}");
        }
    }
}
