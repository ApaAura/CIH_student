using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    abstract class Angajat
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public abstract double CalculeazaSalariul();
        public void Citire()
        {
            Console.Write("Nume : ");
            Nume = Console.ReadLine();
            Console.Write("Prenume : ");
            Prenume = Console.ReadLine();
        }
        public void Afisare()
        {
            Console.WriteLine($"Nume : {Nume}");
            Console.WriteLine($"Prenume : {Prenume}");
        }
    }
}
