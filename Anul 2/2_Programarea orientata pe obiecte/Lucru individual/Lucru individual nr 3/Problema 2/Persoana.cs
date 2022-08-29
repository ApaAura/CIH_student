using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public void Citire()
        {
            Console.Write("Nume : ");
            Nume = Console.ReadLine();
            Console.Write("Prenume : ");
            Prenume = Console.ReadLine();
        }
        public void Afisare()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Numele : {Nume}");
            Console.WriteLine($"Prenume : {Prenume}");
            Console.WriteLine("--------------------------------");
        }
    }
}
