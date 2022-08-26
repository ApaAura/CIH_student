using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class SmartTV : Produs
    {
        public string ModelBoxe { get; set; }
        public double Diagonala { get; set; }
        public override void Citire()
        {
            Console.WriteLine("Introduceti datele despre SmartTV : ");
            base.Citire();
            Console.Write("ModelBoxe : ");
            ModelBoxe = Console.ReadLine();
            Console.Write("Diagonala : ");
            Diagonala=double.Parse(Console.ReadLine());
        }
        public override void Info()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Datele SmartTv-ului : ");
            Console.WriteLine("-------------------------------");
            base.Info();
            Console.WriteLine($"Model Boxe : {ModelBoxe}");
            Console.WriteLine($"Diagonala : {Diagonala}");
        }
    }
}
