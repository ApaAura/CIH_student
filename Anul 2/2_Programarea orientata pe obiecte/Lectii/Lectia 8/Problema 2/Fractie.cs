using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Fractie
    {
        public int Numitor { get; set; }
        public int Numarator { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele :");
            Console.Write("Numarator = ");
            Numarator = int.Parse(Console.ReadLine());
            Console.Write("Numitor = ");
            Numitor = int.Parse(Console.ReadLine());
        }
        public static Fractie operator ++(Fractie f1)
        {
            return new Fractie
            {
                Numarator = f1.Numarator +f1.Numitor,
                Numitor = f1.Numitor
            };
        }
        public static Fractie operator -- (Fractie f1)
        {
            return new Fractie
            {
                Numarator = f1.Numarator - f1.Numitor,
                Numitor = f1.Numitor
            };
        }
        public static Fractie operator +(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numitor + f2.Numarator * f1.Numitor,
                Numitor = f1.Numitor * f2.Numitor
            };
        }
        public static Fractie operator *(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numarator,
                Numitor = f1.Numitor * f2.Numitor
            };
        }
        public static Fractie operator /(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numitor,
                Numitor = f1.Numitor * f2.Numarator
            };
        }
        public override string ToString()
        {
            return $"{this.Numarator}/{this.Numitor}";
        }
    }
}
