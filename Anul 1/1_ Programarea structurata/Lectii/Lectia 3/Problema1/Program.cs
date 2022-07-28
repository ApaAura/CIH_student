using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Distanţa dintre două oraşe A şi B este de x km. Un şofer cu automobilul, parcurge
               această distanţă în a minute. Elaboraţi un program prin intermediul căruia la ecran
               se va afişa viteza medie a automobilului, dacă valorile lui x şi a se citesc 
               de la tastatură.  */

            Console.Write("distanta = ");
            double distanta = double.Parse(Console.ReadLine());
            Console.Write("timpul = ");
            double timpul = double.Parse(Console.ReadLine());
            double v = distanta / timpul;

            Console.WriteLine($"Viteza medie = {v:f2} km/h");
            Console.ReadKey();

        }
    }
}
