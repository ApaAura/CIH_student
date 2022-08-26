using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Spital : Cladire
    {
        public int NrMaximPacienti { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele spitalului : ");
            base.Citire();
            Console.Write("Numarul maxim de pacienti : ");
            NrMaximPacienti=int.Parse(Console.ReadLine());
        }
        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unui spital");
            base.Materiale();
            Console.WriteLine("Paturi");
            Console.WriteLine("Dulapuri");
            Console.WriteLine("Echipamente medicale");
        }
    }
}
