using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Angajat
    {
        public string Nume { get; set; }
        public double Salariu { get; set; }
        public virtual void Citire()
        {
            Console.Write("Nume : ");
            Nume=Console.ReadLine();
            Console.Write("Salariu : ");
            Salariu=double.Parse(Console.ReadLine());
        }
        public virtual void Info()
        {
            Console.WriteLine($"Nume : {Nume}");
            Console.WriteLine($"Salariu : {Salariu}");
        }
    }
}
