using System;

namespace Problema5
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
            double f = (Math.Sin(x) + Math.Sin(y)) / (Math.Pow(Math.E, y) + Math.Pow(Math.E, x));

            //Afisarea datelor 
            Console.WriteLine($"f({x}, {y}) = {f:F4}");

            Console.ReadKey();
        }
    }
}
