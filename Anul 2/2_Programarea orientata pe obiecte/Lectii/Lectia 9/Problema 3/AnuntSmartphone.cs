using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class AnuntSmartphone : Anunt
    {
        public int RAM { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele smartphoneului : ");
            base.Citire();
            Console.Write("RAM : ");
            RAM =int.Parse(Console.ReadLine());
        } 
        public void Informatii()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datele smartphoneului :");
            Console.WriteLine("--------------------------------");
            base.Informatii();
            Console.WriteLine($"RAM : {RAM} GB");
        }
    }
}
