using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Calculator : DispozitivElectronic
    {
        public string TipProcesor { get; set; }
        public int MemorieRAM { get; set; }
        public int SpatiuDeStocare { get; set; }
        public void Citire()
        {
            base.Citire();
            Console.Write("Tip procesor : ");
            TipProcesor = Console.ReadLine();
            Console.Write("Momoria RAM : ");
            MemorieRAM=int.Parse(Console.ReadLine());
            Console.Write("Spatiu de stocare : ");
            SpatiuDeStocare=int.Parse(Console.ReadLine());
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"Tipul procesorului : {TipProcesor}");
            Console.WriteLine($"Memoria RAM : {MemorieRAM}");
            Console.WriteLine($"Spatiu de stocare : {SpatiuDeStocare}");

        }
    }
}
