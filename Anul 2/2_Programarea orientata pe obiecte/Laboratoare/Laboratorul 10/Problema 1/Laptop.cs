using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Laptop : Produs
    {
        public int MemorieRAM { get; set; }
        public string TipProcesor { get; set; }
        public override void Citire()
        {
            Console.WriteLine("Introduceti datele despre Laptop : ");
            base.Citire();
            Console.Write("Memorie RAM : ");
            MemorieRAM=int.Parse(Console.ReadLine());
            Console.Write("Tip procesor : ");
            TipProcesor=Console.ReadLine();
        }
        public override void Info()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Datele despre laptop : ");
            Console.WriteLine("-------------------------------");
            base.Info();
            Console.WriteLine($"Memorie RAM : {MemorieRAM}");
            Console.WriteLine($"Tip procesor : {TipProcesor}");
        }
    }
}
