using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class SmartPhone : Produs
    {
        public double MahBaterie { get; set; }
        public bool FastCharge { get; set; }

        public override void Citire()
        {
            Console.WriteLine("Introduceti datele SmartPhone : ");
            base.Citire();
            Console.Write("Mah baterie : ");
            MahBaterie = double.Parse(Console.ReadLine());
            Console.Write("Fast Charge : ");
            FastCharge = bool.Parse(Console.ReadLine());
        }

        public override void Info()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Datele despre SmartPhone : ");
            Console.WriteLine("-------------------------------");
            base.Info();
            Console.WriteLine($"Mah baterie : {MahBaterie}");
            Console.WriteLine($"Fast Charge : {FastCharge}");
        }
    }
}
