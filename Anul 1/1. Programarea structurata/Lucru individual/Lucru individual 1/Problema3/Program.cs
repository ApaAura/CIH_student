using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* De la tastatură se întroduc două numere întregi.
             Să se determine, ce este mai mare, suma patratelor acestor numere sau patratul sume lor.
            */
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            double F;
            F = (Math.Pow(a, 2) + Math.Pow(b, 2));
            double D;
            D = (Math.Pow(a + b, 2));

            if(F>D)
            {
                Console.WriteLine($"Suma patratelor este mai mare {F}>{D}" ,F,D);
            }
            else
            {
                Console.WriteLine($"Patratul sumei este mai mare {D}>{F}",D,F);
            }
            Console.ReadKey();
        }
    }
}
