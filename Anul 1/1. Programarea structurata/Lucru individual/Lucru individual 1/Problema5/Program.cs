using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             De la tastatură se întroduc lungimile laturilor unui triunghi: a,b,c. 
             Să se determine dacă ele formează triunghi dreptughic.
            */

            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (a*a+b*b==c*c)
            {
                Console.WriteLine("Laturile formeaza triunghi dreptunghic");
            }
            else
            {
                if (c*c+b*b==a*a)
                {
                    Console.WriteLine("Laturile formeaza triunghi dreptunghic");
                }
                else
                {
                    if (c*c+a*a==b*b)
                    {
                        Console.WriteLine("Laturile formeaza triunghi dreptunghic");
                    }
                    else
                    {
                        Console.WriteLine("Laturile nu formeaza triunghi dreptunghic");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
