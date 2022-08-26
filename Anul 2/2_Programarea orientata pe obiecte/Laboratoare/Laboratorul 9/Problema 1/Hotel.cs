using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Hotel :Cladire
    {
        public int NrStele { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele hotelului : ");
            base.Citire();
            Console.Write("Numarul de stele :");
            NrStele=int.Parse(Console.ReadLine());  
        }
        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unui hotel");
            base.Materiale();
            Console.WriteLine("Mobilier Receptie");
            Console.WriteLine("Paturi");
            Console.WriteLine("Dulapuri");
        }
    }
}
