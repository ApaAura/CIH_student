using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sunt date lungimile laturilor unu triunghi: a,b,c. Să se determine, 
             * dacă acest triunghi este isoscel. */

            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                if (b != c)
                { Console.WriteLine("Laturile formeaza un triunghi isoscel"); }
                else
                { Console.WriteLine("Laturile nu formeaza un triunghi isoscel"); }
            }
            if (a == c)
            {
                if (c != b)
                { Console.WriteLine("Laturile formeaza un triunghi isoscel"); }
                else
                { Console.WriteLine("Laturile nu formeaza un triunghi isoscel"); }
            }
            if (b == c)
            {
                if (c != a)
                { Console.WriteLine("Laturile formeaza un triunghi isoscel"); }
                else
                { Console.WriteLine("Laturile nu formeaza un triunghi isoscel"); }
            }
            Console.ReadKey();
        }
    }
}
