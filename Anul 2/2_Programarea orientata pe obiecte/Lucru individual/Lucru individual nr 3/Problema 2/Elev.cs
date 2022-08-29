using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Elev : Persoana
    {
        public string Grupa { get; set; }
        public int AnulDeStudii {get; set;}
        public double NotaMedie {get; set;}
        public void Citire()
        {
            Console.WriteLine("Introduceti datele elevului : ");
            base.Citire();
            Console.Write("Grupa : ");
            Grupa = Console.ReadLine();
            Console.Write("Anul de studii : ");
            AnulDeStudii = int.Parse(Console.ReadLine());
            Console.Write("Nota medie : ");
            NotaMedie = double.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("Datele elevului : ");
            base.Afisare();
            Console.WriteLine($"Grupa : {Grupa}");
            Console.WriteLine($"Anul de studii : {AnulDeStudii}");
            Console.WriteLine($"Nota medie : {NotaMedie}");
        }
    }
}
