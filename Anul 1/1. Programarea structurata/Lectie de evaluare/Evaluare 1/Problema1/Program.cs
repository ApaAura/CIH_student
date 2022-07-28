using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citirea datelor de la tastatura 
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("t=");
            double t = double.Parse(Console.ReadLine());

            //Blocul de calcul 
            double F;
            F = (9.8 * Math.Pow(a, 2)) + (5.52 * Math.Cos(Math.Pow(t, 5)));

            //Afisarea datelor 
            Console.WriteLine($"F = {F}", F);
            Console.ReadKey();


        }
    }
}
