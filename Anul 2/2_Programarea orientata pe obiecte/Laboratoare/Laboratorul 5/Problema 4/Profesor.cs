using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Profesor : Angajat
    {
        public string Catedra { get; set; }
        public int nrOrePeSaptamana { get; set; }
        public void CitireDate()
        {
            Console.WriteLine("Introduceti datele profesorului : ");
            base.CitireDate();
            Console.Write("Catedra : ");
            Catedra = Console.ReadLine();
            Console.Write("Numarul de ore pe saptamana : ");
            nrOrePeSaptamana = int.Parse(Console.ReadLine());
        }
        public void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Catedra : {Catedra}");
            Console.WriteLine($"Numarul de ore pe saptamana : {nrOrePeSaptamana}");
        }
    }
}
