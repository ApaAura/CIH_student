using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class AnuntAutomobil : Anunt
    {
        public double KmParcursi { get; set; }
        public void Citire()
        {
            Console.WriteLine("Datele anuntului automobilului :");
            base.Citire();
            Console.Write("Km parcursi : ");
            KmParcursi = double.Parse(Console.ReadLine());
        }
        public void Informatii()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datele Automobilui : ");
            Console.WriteLine("--------------------------------");
            base.Informatii();
            Console.WriteLine($"KM parcursi : {KmParcursi}");
        }

    }
}
