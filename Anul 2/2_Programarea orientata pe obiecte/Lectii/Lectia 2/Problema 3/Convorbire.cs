using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Convorbire
    {
        //constructor fara parametri
        public Convorbire()
        {
        }
        //Constructor cu parametri
        public Convorbire(int durata, int costul)
        {
            Durata = durata;
            Costul = costul;
        }
        //Constructor de copiere
        public Convorbire(Convorbire aux)
        {
            Durata = aux.Durata;
            Costul = aux.Costul;
        }

        public int Durata { get; set; }
        public int Costul { get; set; }
        public void Citire()
        {
            Console.Write("Introduceti durata convorbirii: ");
            Durata=int.Parse(Console.ReadLine());
            Console.Write("Introduceti costul unui minut: ");
            Costul=int.Parse(Console.ReadLine());
        }
        public int Cost => Durata * Costul;
        public void Afisare()
        {
            Console.Clear();
            Console.WriteLine($"Costul convorbirii: {Cost}");
        }
    }
}
