using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Screieti un program care calculeaza prin mai multe metode aria unui triunghi.
            Arie(5, 3, 4);
            Arie(5,6);
            Arie(3);
            Arie(6, 5, 45, 1);
            Console.ReadKey();
        }
        private static void Arie(double v1, double v2, double v3, double v4)
        {
            //Aria= 1/2(v1*V2*sin(v3))
            double Aria = 1/2*(v1 * v2 * Math.Sin(v3)*v4);
            Console.WriteLine($"Aria triunghiului este: {Aria}");
        }
        private static void Arie(int x)
        {
            //Aria in triunghiul echilateral
            double Aria = (x*x*Math.Sqrt(3)) / 4;
            Console.WriteLine($"Aria triunghiului este: {Aria}");
        }

        private static void Arie(int m, int n)
        {
            //Aria in triunghiul dreptunghic (m-cateta, n-inaltime)
            double Aria = (m * n) / 2;
            Console.WriteLine($"Aria triunghiului este: {Aria}");
        }

        private static void Arie(int a, int b, int c)
        {
            //Formula lui Heron
            int sp = (a + b + c) / 2;
            double Aria = Math.Sqrt(sp*(sp - a)*(sp - b)*(sp - c));
            Console.WriteLine($"Aria triunghiului este: {Aria}");
        }
    }
}
