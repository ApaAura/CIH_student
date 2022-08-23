using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class AngajatAuxiliar : Angajat
    {
        public bool TuraDeNoapte { get; set; }
        public void CitireDate()
        {
            Console.WriteLine("Introduceti datele angajatului auxiliar : ");
            base.CitireDate();
            Console.Write("Tura de noapte true/false : ");
            TuraDeNoapte = bool.Parse(Console.ReadLine());
        }
        public void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Tura de noapte : {TuraDeNoapte}");
        }
    }
}
