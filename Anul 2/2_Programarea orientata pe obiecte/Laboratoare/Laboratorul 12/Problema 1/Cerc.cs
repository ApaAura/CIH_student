using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Cerc : IFiguraGeometrica
    {
        public double Raza { get; set; }
        public Cerc(double raza)
        {
            Raza = raza;
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele cercului : ");
            Console.Write("Raza : ");
            Raza=double.Parse(Console.ReadLine());
        }
        public double Aria() => Math.PI*Raza*Raza;
        public double Perimetru() => 2 * Math.PI * Raza;
        public void Info()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Datele cercului : ");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Raza : {Raza}");
            Console.WriteLine($"Aria : {Aria():F4}");
            Console.WriteLine($"Perimetru : {Perimetru():F4}");
        }
    }
}
