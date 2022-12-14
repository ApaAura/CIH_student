using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citirea datelor initiale
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());

            //Blocul de calcul 
            double f = Math.Sqrt(Math.Abs(x - y) / Math.Sqrt(1 / Math.Abs(x - y)) * (Math.Abs(x) + 1));

            //Afisarea datelor 
            Console.WriteLine($"f({x}, {y}) = {f:F4}");

            Console.ReadKey();
        }
    }
}
