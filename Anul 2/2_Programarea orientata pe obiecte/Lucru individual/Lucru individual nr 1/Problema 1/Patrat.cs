using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Patrat
    {
        public double Latura { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti dimensiunea laturii : ");
            Console.Write("Latura : ");
            Latura = double.Parse(Console.ReadLine());
        }
        public double Perimetru() => Latura * 4;
        public double Aria() => Math.Pow(Latura, 2);
        public double Diagonala() => Latura * Math.Sqrt(2);
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Latura patratului : {Latura} cm");
            Console.WriteLine($"Diagonala : {Diagonala()} cm");
            Console.WriteLine($"Perimetrul : {Perimetru()} cm");
            Console.WriteLine($"Aria : {Aria()} cm^2");
        }
    }
}
