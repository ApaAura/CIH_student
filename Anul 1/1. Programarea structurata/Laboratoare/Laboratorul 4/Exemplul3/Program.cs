using System;

namespace Exemplul3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, c;
            Console.Write("Introdu valoarea x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Introdu valoarea a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Introdu valoarea c = ");
            c = double.Parse(Console.ReadLine());

            double L;
            L = (Math.Sqrt(Math.Pow(Math.E,x) - Math.Pow(Math.Cos(Math.Pow(x,2) * Math.Pow(a , 5)) , 4)+Math.Pow(Math.Atan(a-Math.Pow(x,5)),4))) / (Math.E*Math.Sqrt(Math.Abs(a+x*Math.Pow(c,4))));

            Console.WriteLine("L= {0:F4} ", L);
            Console.ReadKey();
        }
    }
}
