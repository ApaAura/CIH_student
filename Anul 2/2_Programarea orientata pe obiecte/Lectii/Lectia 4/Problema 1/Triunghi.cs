using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Triunghi
    {
        public double latura1 { get; set; }
        public double latura2 { get; set; }
        public double latura3 { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele : ");
            Console.Write("Latura 1: ");
            latura1 = double.Parse(Console.ReadLine());
            Console.Write("Latura 2: ");
            latura2 = double.Parse(Console.ReadLine());
            Console.Write("Latura 3: ");
            latura3 = double.Parse(Console.ReadLine());
        }
        public double Semiperimetru() => (latura1 + latura2 + latura3) / 2;
        public double Aria() => Math.Sqrt(Semiperimetru() * (Semiperimetru() - latura1) * (Semiperimetru() - latura2) * (Semiperimetru() - latura3));
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine("Datele triunghiului :");
            Console.WriteLine($"Latura 1 : {latura1}\nLatura 2 : {latura2}\nLatura 3 : {latura3}");
            Console.WriteLine($"Semiperimetrul : {Semiperimetru()}\nAria : {Aria}");
            Console.ReadKey();
        }
    }
}
