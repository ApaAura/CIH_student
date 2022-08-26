using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class AnuntApartament : Anunt
    {
        public int nrCamere { get; set; }
        public string Regiunea { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele apartamentului : ");
            base.Citire();
            Console.Write("Numarul de camere : ");
            nrCamere = int.Parse(Console.ReadLine());
            Console.Write("Regiunea : ");
            Regiunea = Console.ReadLine();
        }
        public override void Informatii()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datele apartamenului : ");
            Console.WriteLine("--------------------------------");
            base.Informatii();
            Console.WriteLine($"Numarul de camere : {nrCamere}");
            Console.WriteLine($"Regiunea : {Regiunea}");
        }
    }
}
