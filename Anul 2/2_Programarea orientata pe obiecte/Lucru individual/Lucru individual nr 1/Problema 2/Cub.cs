using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Cub
    {
        private double Muchia { get; set; }
        public Cub()
        {
        }
        public Cub(double muchia)
        {
            Muchia = muchia;
        }
        public double Aria() => 6 * Math.Pow(Muchia, 2);
        public double Volum()=>Math.Pow(Muchia, 3);
        public void Afisare()
        {
            Console.WriteLine("Dimensiunile cubului !");
            Console.WriteLine($"Muchia : {Muchia}");
            Console.WriteLine($"Aria : {Aria()} cm^2");
            Console.WriteLine($"Volumul : {Volum()} cm^3");
        }
    }
}
