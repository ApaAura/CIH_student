using System;

namespace Expresii_aritmetice
{
    class Program
    {
        static public int a;
        static public int b;
        static public int c;
        static public int x;
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Citire();
                    Console.WriteLine("A = "+ Functie()); 
                    isValid = true;
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare !");
                    isValid = false;
                }
            }
        }
        private static double Functie()
        {
            double A = 1 / (Math.Sqrt(a * Math.Pow(x, 2) + b * x + c));
            return A;
        }
        private static void Citire()
        {
            Console.WriteLine("Introduceti datele: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}
