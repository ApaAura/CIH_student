using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class AngajatPartTime : Angajat
    {
        public int OreLucrate { get; set; }
        public int PlataPerOra { get; set; }
        public override double CalculeazaSalariul() => OreLucrate * PlataPerOra;
        public void Citire()
        {
            Console.WriteLine("Introduceti datele despre angajatul Part Time :");
            base.Citire();
            Console.Write("Ore lucrate : ");
            OreLucrate=int.Parse(Console.ReadLine());
            Console.Write("Plata per ora : ");
            PlataPerOra=int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Datele angajatului Part Time : ");
            Console.WriteLine("-------------------------------------");
            base.Afisare();
            Console.WriteLine($"Salariu total : {CalculeazaSalariul()}");
        }

    }
}
