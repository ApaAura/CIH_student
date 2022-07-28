using System;

namespace Exemplul2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, l ;
            Console.Write("Introdu valoarea t = ");
            t = double.Parse(Console.ReadLine());
            Console.Write("Introdu valoarea l = ");
            l = double.Parse(Console.ReadLine());

            double R;
            R = (3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9);

            Console.WriteLine("R= {0:F4} ", R);
            Console.ReadKey();
        }
    }
}
