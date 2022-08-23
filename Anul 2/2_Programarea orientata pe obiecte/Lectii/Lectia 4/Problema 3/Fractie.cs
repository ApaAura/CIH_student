using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    public class Fractie
    {
        public double Numarator { get; set; }
        public double Numitor { get; set; }
        public Fractie()
        {
        }
        public Fractie(double numarator, double numitor)
        {
            Numarator = numarator;
            Numitor = numitor;
        }
        public Fractie(Fractie F)
        {
            Numarator = F.Numarator;
            Numitor = F.Numitor;
        }
        public void Citire()
        {
            Console.Write("Numaratorul = ");
            Numarator = double.Parse(Console.ReadLine());
            Console.Write("Numitorul = ");
            Numitor = double.Parse(Console.ReadLine());
        }
        public double Rezultat()
        {
            if (Numitor != 0)
            {
                return (Numarator / Numitor);
            }
            else return 0;
        }
        public void Afisare()
        {
            if (Rezultat() == 0)
            {
                Console.WriteLine("Impartirea la 0 nu are sens !");
            }
            else
            {
                Console.WriteLine($"{Numarator}/{Numitor}={Rezultat()}");
            }
        }
    }
}
