using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    abstract class FiguraGeometrica
    {
        public abstract double Perimetrul();
        public abstract double Aria();
    }
    class Dreptunghi : FiguraGeometrica
    {
        public double Lungime { get; set; }
        public double Latime { get; set; }
        public void Citire()
        {
            Console.Write("Lungime : ");
            Lungime = double.Parse(Console.ReadLine());
            Console.Write("Latime : ");
            Latime = double.Parse(Console.ReadLine());
        }
        public override double Perimetrul() => 2 * (Lungime + Latime);
        public override double Aria() => Lungime * Latime;
        public void Afisare()
        {
            Console.WriteLine($"Latime = {Latime}\nLungime = {Lungime}");
            Console.WriteLine($"Perimetrul = {Perimetrul()}\nAria = {Aria()}");
        }
    }
}
