using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Elev : Persoana
    {
        public string Grupa { get; set; }
        public byte anulDeStudii { get; set; }
        public double media { get; set; }
        public bool Restantier()
        {
            if (media < 5)
            {
                return true;
            }
            return false;
        }
        public void CitireDate()
        {
            Console.WriteLine("Introduceti datele elevului : ");
            base.CitireDate();
            Console.Write("Grupa : ");
            Grupa = Console.ReadLine();
            Console.Write("Anul de studii : ");
            anulDeStudii = byte.Parse(Console.ReadLine());
            Console.Write("Media : ");
            media = double.Parse(Console.ReadLine());
        }
        public void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Grupa : {Grupa}");
            Console.WriteLine($"Anul de studii : {anulDeStudii}");
            Console.WriteLine($"Media : {media}");
        }
    }
}
