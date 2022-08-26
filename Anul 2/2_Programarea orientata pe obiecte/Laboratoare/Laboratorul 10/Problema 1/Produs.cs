using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Produs
    {
        public string Denumire { get; set; }
        public double Pret { get; set; }
        public virtual void Citire()
        {
            Console.Write("Denumire: ");
            Denumire=Console.ReadLine();
            Console.Write("Pret");
            Pret=double.Parse(Console.ReadLine());
        }
        public virtual void Info()
        {
            Console.WriteLine($"Denumire : {Denumire}");
            Console.WriteLine($"Pret : {Pret}");
        }
    }

}