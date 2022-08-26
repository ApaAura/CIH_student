using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class InstitutieDeInvatamant :Cladire
    {
        public string Tip { get; set; }
        public void Citire()
        {
            Console.WriteLine("Introduceti datele institutie : ");
            base.Citire();
            Tip = Console.ReadLine();
        }
        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unei " + "institutii de invatamant");
            base.Materiale();
            Console.WriteLine("Banci");
            Console.WriteLine("Calculatoare");
            Console.WriteLine("Proiectoare");
        }

    }
}
