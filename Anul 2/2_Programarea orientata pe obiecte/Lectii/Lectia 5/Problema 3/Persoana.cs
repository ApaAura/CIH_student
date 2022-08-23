using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    public class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Anul { get; set; }
        public string CNP { get; set; }
        public void Citire()
        {
            Console.Write("Nume : ");
            Nume=Console.ReadLine();
            Console.Write("Prenume : ");
            Prenume=Console.ReadLine();
            Console.Write("Anul : ");
            Anul=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CNP : ");
            CNP=Console.ReadLine();
        }
        public int Varsta() => DateTime.Now.Year - Anul.Year;
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Nume : {Nume}");
            Console.WriteLine($"Prenume : {Prenume}");
            Console.WriteLine($"Varsta : {Varsta()} ani");
            Console.WriteLine($"CNP : {CNP}");
        }
    }
    public class Salariat : Persoana
    {
        public int NrOreLucrate { get; set; }
        public int PlataPerOra { get; set; }
        public int Salariu() => NrOreLucrate * PlataPerOra;
        public void Citire()
        {
            base.Citire();
            Console.Write("Numarul de ore lucrate : ");
            NrOreLucrate = int.Parse(Console.ReadLine());
            Console.Write("Plata per ora : ");
            PlataPerOra = int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            base.Afisare();
            Console.WriteLine($"Salariu : {Salariu()}");
        }
    }
}
