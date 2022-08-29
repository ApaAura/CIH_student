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
        public string Model { get; set; }
        public int PretLei { get; set; }
        public Automobil()
        {
        }
        public Automobil(string marca, string model, int pretLei)
        {
            Marca = marca;
            Model = model;
            PretLei = pretLei;
        }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele automobilului : ");
            Console.Write("Marca : ");
            Marca=Console.ReadLine();
            Console.Write("Model : ");
            Model=Console.ReadLine();
            Console.Write("Pret Lei : ");
            PretLei=int.Parse(Console.ReadLine());
        }  
        public void Afisare()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Datele automobilului : ");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Pret in lei : {PretLei}");
        }
        public void Afisare(bool x)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Datele automobilului : ");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Model : {Model}");
            if (x==true)
            {
                Console.WriteLine($"Pret in euro : {PretLei/20}");
            }
            else
            {
                Console.WriteLine($"Pret in lei : {PretLei}");
            }
        }
    }
}
