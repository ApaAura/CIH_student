using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Produs
    {
        public int Pret { get; set; }
        public string Producator { get; set; }
        public string Distribuitor { get; set; }
        public void Citire()
        {
            Console.Write("Pret : ");
            Pret=int.Parse(Console.ReadLine());
            Console.Write("Producator : ");
            Producator =Console.ReadLine();
            Console.WriteLine("Distribuitor : ");
            Distribuitor=Console.ReadLine();
        }
        public void afisareInformatii()
        {
            Console.WriteLine($"Pret : {Pret}");
            Console.WriteLine($"Producator : {Producator}");
            Console.WriteLine($"Distribuitor : {Distribuitor}");
        }
            
    }
}
