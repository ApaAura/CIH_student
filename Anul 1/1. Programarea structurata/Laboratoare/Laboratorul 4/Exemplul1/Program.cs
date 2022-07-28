using System;

namespace Exemplul1
{
    class Program
    {
        static void Main(string[] args)
        {
            float t, r, y;
            Console.Write("Introdu valoarea t = ");
            t = float.Parse(Console.ReadLine());
            Console.Write("Introdu valoarea r = ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Introdu valoarea y = ");
            y = float.Parse(Console.ReadLine());
            double w;

            w = (4 * Math.Pow(t, 3) + Math.Log(r)) / (Math.Exp(y + r) + 7.2 * Math.Sin(r));
            
            //Afisam cu 5 cifre dupa virgula
            Console.WriteLine("w = {0:F5} ", w);
            Console.ReadKey();
        }
    }
}
