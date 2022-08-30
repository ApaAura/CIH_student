using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class DataScientist: Angajat
    {
        public string TipBazaDeDateUtilizata { get; set; }
        public override void Citire()
        {
            Console.WriteLine("Introduceti datele Date Scientist : ");
            base.Citire();
            Console.Write("Tipul bazei de date utilizata : ");
            TipBazaDeDateUtilizata = Console.ReadLine();
        }
        public override void Info()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datele Date Scientist : ");
            Console.WriteLine("--------------------------------");
            base.Info();
            Console.WriteLine($"Tipul bazei de dare utilizata : {TipBazaDeDateUtilizata}");
        }
    }
}
