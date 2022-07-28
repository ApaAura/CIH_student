using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sunt date lungimile laturilor unu triunghi: a,b,c. 
             * Să se determine, dacă acest triunghi este echilateral. */

            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (a == b||a == c||b == c)
            {
                  Console.WriteLine("Laturile formeaza triunghi echilateral"); 
            }
            else
            {
                Console.WriteLine("Laturile nu formeaza triunghi echilateral");
            }
            Console.ReadKey();
        }
    }
}
