using System;

namespace Problema7
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
            double f = ((x - y) / (Math.Abs(x + y) + 1)) + (((Math.Pow(x, 2) - Math.Pow(y, 2))) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 1));

            //Afisarea datelor 
            Console.WriteLine($"f({x}, {y}) = {f:F4}");

            Console.ReadKey();
        }
    }
}
