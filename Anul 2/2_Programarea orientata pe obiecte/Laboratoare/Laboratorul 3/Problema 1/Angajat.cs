using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    public class Angajat
    {
        public string Nume { get; set; }
        private int OreLucrate { get; set; }
        private int PlataPerOre { get; set; }
        private string IDNP { get; set; }
        public Angajat()
        {
            Nume = "";
            OreLucrate = 0;
            PlataPerOre = 0;
            IDNP = "";
        }
        public Angajat(string nume, int oreLucrate, int plataPerOre, string iDNP)
        {
            Nume = nume;
            OreLucrate = oreLucrate;
            PlataPerOre = plataPerOre;
            IDNP = iDNP;
        }
        public void Citire()
        {
            Console.WriteLine("Datele anagajatului :");
            Console.Write("Nume : ");
            Nume = Console.ReadLine();
            Console.Write("Numarul de ore lucrate : ");
            OreLucrate = int.Parse(Console.ReadLine());
            Console.Write("Plata per ora : ");
            PlataPerOre= int.Parse(Console.ReadLine());
            Console.Write("IDNP : ");
            IDNP = Console.ReadLine();
            Console.WriteLine("-------------------------------");
        }
        private double CalculareSalariu() => OreLucrate * PlataPerOre;
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Numele anagajatului : {Nume}");
            Console.WriteLine($"Salariul angajatului : {CalculareSalariu()}");
        }
    }
}
