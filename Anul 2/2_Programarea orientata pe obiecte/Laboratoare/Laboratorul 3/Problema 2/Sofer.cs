using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    public class Sofer
    {
        public string Nume { get; set; }
        private int AnulNasterii { get; set; }
        public int DistantaParcursa { get; set; }
        private int PlataPerKm { get; set; }
        public Sofer()
        {
        }
        public Sofer(string nume, int anulNasterii, int distantaParcursa, int plataPerKm)
        {
            Nume = nume;
            AnulNasterii = anulNasterii;
            DistantaParcursa = distantaParcursa;
            PlataPerKm = plataPerKm;
        }
        public void Citire()
        {
            Console.WriteLine("Datele soferului : ");
            Console.Write("Numele : ");
            Nume =Console.ReadLine();
            Console.Write("Anul nasterii : ");
            AnulNasterii =int.Parse(Console.ReadLine());
            Console.Write("Distanta parcursa : ");
            DistantaParcursa=int.Parse(Console.ReadLine());
            Console.Write("Plata per km : ");
            PlataPerKm=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
        }
        private int Salariu() => DistantaParcursa * PlataPerKm;
        private int Varsta() => DateTime.Now.Year - AnulNasterii;
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine("Datele soferului : ");
            Console.WriteLine($"Numele : {Nume}");
            Console.WriteLine($"Salariul : {Salariu()}");
            Console.WriteLine($"Varsta : {Varsta()}");
        }
    }
}
