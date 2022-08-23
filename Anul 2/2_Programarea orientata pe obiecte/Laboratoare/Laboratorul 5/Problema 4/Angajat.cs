using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Angajat : Persoana
    {
        public DateTime dataAngajarii { get; set; }
        public double salariuLunarBrut { get; set; }
        public double FondulSocial() => 24 * salariuLunarBrut;
        public double Stagiu() => DateTime.Now.Year - dataAngajarii.Year;
        public void CitireDate()
        {
            base.CitireDate();
            Console.Write("Data angajarii : ");
            dataAngajarii = DateTime.Parse(Console.ReadLine());
            Console.Write("Salariul lunar brut : ");
            salariuLunarBrut = double.Parse(Console.ReadLine());
        }
        public void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Stagiu : {Stagiu()}");
            Console.WriteLine($"Salariu lunar brut : {salariuLunarBrut}");
            Console.WriteLine($"Fondul social : {FondulSocial()}");
        }
    }
}
