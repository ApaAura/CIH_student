using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Automobil
    {
        public string Marca { get; set; }
        public int AnulEditiei { get; set; }
        public string Culoare { get; set; }
        public int Pret { get; set; }
        public double Capacitate { get; set; }
        public double ConsumPer100km { get; set; }

        public Automobil()
        {
        }
        public Automobil(string marca, int anulEditiei, string culoare, int pret, double capacitate, double consumPer100km)
        {
            Marca = marca;
            AnulEditiei = anulEditiei;
            Culoare = culoare;
            Pret = pret;
            Capacitate = capacitate;
            ConsumPer100km = consumPer100km;
        }
        public void Citire()
        {
            Console.Write("Marca : ");
            Marca=Console.ReadLine();
            Console.Write("Anul editiei : ");
            AnulEditiei=int.Parse(Console.ReadLine());
            Console.Write("Culoarea : ");
            Culoare=Console.ReadLine();
            Console.Write("Pret : ");
            Pret =int.Parse(Console.ReadLine());
            Console.Write("Capacitate motorului : ");
            Capacitate=double.Parse(Console.ReadLine());
            Console.Write("Consum per 100 km : ");
            ConsumPer100km=double.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Anul editiei : {AnulEditiei}");
            Console.WriteLine($"Culoarea : {Culoare}");
            Console.WriteLine($"Pret : {Pret}");
            Console.WriteLine($"Capacitatea motorului : {Capacitate}");
            Console.WriteLine($"Consumul per 100 km : {ConsumPer100km}");
        }
    }
}
