using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Salariu
    {
        public Salariu()
        {
            SalariuZi = 0;
            NrZile = 0;
        }
        public Salariu(int salariuZi, int nrZile)
        {
            SalariuZi = salariuZi;
            NrZile = nrZile;
        }
        public int SalariuZi { get; set; }
        public int NrZile { get; set; }
        public void Citire()
        {
            Console.Write("Introduceti salariul pentru o zi: ");
            SalariuZi=int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de zile lucrate: ");
            NrZile = int.Parse(Console.ReadLine());
        }
        public int SalariuAn => SalariuZi * NrZile*12;
        public void Afisare()
        {
            Console.WriteLine($"Salariu pentru o luna: {SalariuAn/12}");
            Console.WriteLine($"Salariul pentru un an: {SalariuAn}");
        }
    }
}
