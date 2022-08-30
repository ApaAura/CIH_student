using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Anunt
    {
        public string Autor { get; set; }
        public double Pret { get; set; }
        public void Citire()
        {
            Console.Write("Autorul : ");
            Autor=Console.ReadLine();
            Console.Write("Pretul : ");
            Pret=double.Parse(Console.ReadLine());
        }
        public void Informatii()
        {
            Console.WriteLine($"Autor : {Autor}");
            Console.WriteLine($"Pret : {Pret}");
        }
    }
}
