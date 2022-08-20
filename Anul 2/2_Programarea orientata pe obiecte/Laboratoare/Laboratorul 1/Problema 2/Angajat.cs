using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_2
{
    class Angajat
    {
        public string nume;
        public string functia;
        public int anulAngajarii;
        public int oreLucrate;
        public double plataPeOra;
        public void Citire()
        {
            Console.Write("Numele angajatului: ");
            nume = Console.ReadLine();

            Console.Write("Functia angajatului: ");
            functia = Console.ReadLine();

            Console.Write("Anul angajarii: ");
            anulAngajarii = int.Parse(Console.ReadLine());

            Console.Write("Ore lucrate: ");
            oreLucrate = int.Parse(Console.ReadLine());

            Console.Write("Plata per ora: ");
            plataPeOra = double.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine($"Numele: {nume}");
            Console.WriteLine($"Functia: {functia}");
            Console.WriteLine($"Anul angajarii: {anulAngajarii}");
            Console.WriteLine($"Ore lucrate: {oreLucrate}");
            Console.WriteLine($"Plata per ora: {plataPeOra}");
            Console.WriteLine($"Salariu calculat: {SalariuCalculat()}");
            Console.WriteLine($"Spor: {Spor()}");
            Console.WriteLine($"Salariu primit: {SalariuPrimit()}");
        }
        public int Stagiu() => DateTime.Now.Year - anulAngajarii;
        public double SalariuCalculat() => plataPeOra * oreLucrate;
        public double Spor() => SalariuCalculat() / 100 * 15;
        public double SalariuPrimit() => SalariuCalculat() + Spor();
    }
}
