using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Este dat un plan de coordonate și un punct (x,y) citit de la tastatură. 
             Determinați dacă acest punct se află în domeniul hașurat din planul de coordonate.
              */

            int x,y;
            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            y = int.Parse(Console.ReadLine());

            if (x > 40)
                {
                    if (y > 40)
                    {
                        Console.WriteLine("Punctul apartine domeniului hasurat");
                    }
                    else
                    {
                        Console.WriteLine("Punctul nu apartine domeniului hasurat");
                    }
                }
            if (x < -40)
            {
                if (y < -40)
                {
                    Console.WriteLine("Punctul nu apartine domeniului hasurat");
                }
                else
                {
                    Console.WriteLine("Punctul apartine domeniului hasurat");
                }
            }
            Console.ReadKey();
        }
    }
}
