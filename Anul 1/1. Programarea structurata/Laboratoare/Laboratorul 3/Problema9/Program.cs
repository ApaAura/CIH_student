using System;

namespace Problema._9
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
            double f = (x + y) / (Math.Sqrt(((Math.Pow(x, 2) + Math.Pow(y, 2) + 1) * Math.Pow(Math.Sin(x + y), 2))));

            //Afisarea datelor 
            Console.WriteLine($"f({x}, {y}) = {f:F4}");

            Console.ReadKey();
        }
    }
}
