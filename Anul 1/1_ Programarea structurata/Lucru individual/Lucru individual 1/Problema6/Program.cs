using System;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            De la tastatură se întroduc lungimile laturilor unui triunghi: a,b,c.
            Să se determine dacă ele formează triunghi echilateral
            */
           
            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                if (b == c)
                {
                    if (c == a)
                    { Console.WriteLine("Laturile formeaza triunghi echilateral"); }
                }
            }
            else 
            {
                Console.WriteLine("Laturile nu formeaza triunghi echilateral");
            }
            Console.ReadKey(); 
        }
    }
}
