using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, m, n;
            Console.Write("Distanta dintre orase, x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Costul unui litru de combustibil, m = ");
            m = double.Parse(Console.ReadLine());
            Console.Write("Consumul in medie de litri la 100 km, n = ");
            n = double.Parse(Console.ReadLine());

            // Calculam costul pentru 1 km 
            double F; 
            F = (m / 100) * n;
            double C;
            C = (x * F) / 1;

            Console.WriteLine($"Costul deplasarii este egal cu {C} ", C);
            Console.ReadKey();
        }
    }
}
