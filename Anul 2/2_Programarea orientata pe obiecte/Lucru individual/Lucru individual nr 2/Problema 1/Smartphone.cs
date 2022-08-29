using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Smartphone : Dispozitiv
    {
        public double dimensiuneEcran { get; set; }
        public void CitireInformatii()
        {
            Console.WriteLine("Introduceti datele smartphoneului : ");
            base.CitireInformatii();
            Console.Write($"Dimensiunea ecranului : ");
            dimensiuneEcran =double.Parse(Console.ReadLine());
        }
        public void AfisareInformatii()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Datele smartphoneului : ");
            Console.WriteLine("-----------------------------");
            base.AfisareInformatii();
            Console.WriteLine($"Dimensiunea ecranului : {dimensiuneEcran}");
        }
    }
}
