using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class ProdusAlimentar : Produs
    {
        public int Valabilitate { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele produsului alimentar : ");
            base.Citire();
            Console.Write("Valabilitate : ");
            Valabilitate=int.Parse(Console.ReadLine());
        }
        public void afisareInforatii()
        {
            Console.WriteLine("Datele produsului alimentar : ");
            base.afisareInformatii();
            Console.WriteLine($"Valabilitate : {Valabilitate}");
        }
    }
}
