using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class AngajatFullTime : Angajat
    {
        public int SalariuFix { get; set; }
        public int Bonus { get; set; }
        public override double CalculeazaSalariul() => SalariuFix + Bonus;
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre angajatul Full Time : ");
            base.Citire();
            Console.Write("Salariul fix : ");
            SalariuFix=int.Parse(Console.ReadLine());
            Console.Write("Bonus : ");
            Bonus=int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Datele angajatului Full Time : ");
            Console.WriteLine("-------------------------------------");
            base.Afisare();
            Console.WriteLine($"Salariu total : {CalculeazaSalariul()}");
        }
        
    }
}
