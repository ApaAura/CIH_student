using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            double t;
            Console.Write("Introdu numarul de ani t = ");
            t = double.Parse(Console.ReadLine());

            double L;
            L = t * 365;
            double Z;
            Z = t * 365;
            double H;
            H = t * 24 * 365;

            Console.WriteLine($"{L} luni {Z} zile {H} ore. ", L, Z, H);
            Console.ReadKey();
        }
    }
}
