using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class TeamLeader: Angajat
    {
        public int NrProiecteFinalizate { get; set; }
        public override void Citire()
        {
            Console.WriteLine("Introduceti datele Team Leader : ");
            base.Citire();
            Console.Write("Numarul de proiece finalizate : ");
            NrProiecteFinalizate=int.Parse(Console.ReadLine());
        }
        public override void Info()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datele Team Leader : ");
            Console.WriteLine("--------------------------------");
            base.Info();
            Console.WriteLine($"Numarul de proiecte finalizate : {NrProiecteFinalizate}");
        }
    }
}
