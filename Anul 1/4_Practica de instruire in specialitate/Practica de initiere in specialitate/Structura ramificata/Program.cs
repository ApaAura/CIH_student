using System;

namespace Structura_ramificata
{
    class Program
    {
        static public int a;
        static public int b;
        static public int c;
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Citire();
                    Console.WriteLine(Verificare(a, b, c)); 
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare !");
                    isValid = false;
                }
            }
        }
        private static bool Verificare(int a, int b, int c)
        {
            if ((a + b > c) & (a + c > b) & (c + b > a))
            {
                return true;
            }
            else return false;
        }
        private static void Citire()
        {
            Console.WriteLine("Introduceti dimensiunile laturilor: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
        }
    }
}
