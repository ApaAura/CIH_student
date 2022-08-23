using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    public class Anunt
    {
        public string Autor { get; set; }
        public double Pret { get; set; }
        public string NrContact { get; set; }
        public void Citire()
        {
            Console.Write("Autor : ");
            Autor=Console.ReadLine();
            Console.Write("Pret : ");
            Pret=double.Parse(Console.ReadLine());
            Console.Write("Numarul de contact : ");
            NrContact=Console.ReadLine();
        }
        public void Afisare()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Datele Anuntului : ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Autor : {Autor}");
            Console.WriteLine($"Pret : {Pret}");
            Console.WriteLine($"Numarul de contact : {NrContact}");
        }
    }
    public class AnuntApartament : Anunt 
    {
        public double MetriPatrati { get; set; }
        public string Regiune { get; set; }
        public int NrCamere { get; set; }
        public void CitireDate()
        {
            Console.Write("Numarul de metri^2 : ");
            MetriPatrati=double.Parse(Console.ReadLine());
            Console.Write("Rugiune : ");
            Regiune=Console.ReadLine();
            Console.Write("Numarul de camere : ");
            NrCamere=int.Parse(Console.ReadLine());
            base.Citire();
        }
        public void AfisareDate()
        {
            base.Afisare();
            Console.WriteLine($"Metri patrati : {MetriPatrati}");
            Console.WriteLine($"Regiunea : {Regiune}");
            Console.WriteLine($"Numarul de camere : {NrCamere}");
        }
    }
}
