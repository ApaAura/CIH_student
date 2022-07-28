using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                 Numărul unui bilet este format din șase cifre.
                 Elaborați o aplicație ce va detemina dacă acest bilet este ”norocos”.
                 (Biletul se consideră ”norocos”, dacă suma primelor trei cifre din scrierea 
                 lui este egală cu suma ultimelor trei cifre).
            */

            string a ="";
            Console.Write("a= ");
            a = Console.ReadLine();

            if (a.Length != 6 )
            {
                Console.WriteLine("Numarul nu are 6 cifre");
            }
            else 
            {
                if((a[0]-'0')+(a[1]-'0')+(a[2] - '0') == (a[3] - '0') + (a[4] - '0') + (a[5] - '0'))
                {
                    Console.WriteLine("Biletul este norocos");
                }
                else
                {
                    Console.WriteLine("Biletul nu este norocos");
                }

            }
            Console.ReadKey();
        }
    }
}
