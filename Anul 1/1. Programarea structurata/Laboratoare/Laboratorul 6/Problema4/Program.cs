using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Este dat un număr din două cifre să se determine, 
             dacă cifrele din scrierea acestui număr sânt egale. */

            int a ,a1,a2;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            a1 = a % 10;
            a2 = a / 10;
            if (a1==a2)
            {
                Console.WriteLine("Sunt egale");
            }
            else
            {
                Console.WriteLine("Nu sunt egale");
            }
            Console.ReadKey();
        }
    }
}
