using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Angajat
    {
        public Angajat(string nume, string prenume, string departament, double salariu)
        {
            Nume = nume;
            Prenume = prenume;
            Departament = departament;
            Salariu = salariu;
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Departament { get; set; }
        public double Salariu { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele : ");
            Console.Write("Nume : ");
            Nume = Console.ReadLine();
            Console.Write("Prenume : ");
            Prenume = Console.ReadLine();
            Console.Write("Departament : ");
            Departament = Console.ReadLine();
            Console.Write("Salariu");
            Salariu=double.Parse(Console.ReadLine());
        }
        public void AfisareDate()
        {
            Console.WriteLine("Datele angajatului : ");
            Console.WriteLine($"Nume Prenume : {Nume} {Prenume}");
            Console.WriteLine($"Departament : {Departament}");
            Console.WriteLine($"Salariu : {Salariu}");
        }


    }
}
