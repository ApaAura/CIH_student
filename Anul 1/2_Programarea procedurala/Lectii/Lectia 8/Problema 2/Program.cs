using System;

namespace Problema_2
{
    class Program
    {
        /*
         Se consideră numerele naturale din mulţimea {1, 2, 3, ..., n}. Să se
         determine toate elementele acestei mulţimi, pentru care suma
         cifrelor este egală cu un număr dat m.
         */
        static void Main(string[] args)
        {
            int n;
            int valoare;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea: ");
            valoare = int.Parse(Console.ReadLine());
            int cantitate = 0;
            for (int i = 0; i < n; i++)
            {
                if (Solutie(i,valoare))
                {
                    Prelucrare(i, ref cantitate);
                }
            }
            Console.WriteLine($"\n Astfel de numere sunt: {cantitate}");
            Console.ReadKey();
        }
        private static void Prelucrare(int i, ref int cantitate)
        {
            Console.WriteLine($"Numarul={i}");
            cantitate++;
        }
        private static bool Solutie(int i, int valoare)
        {
            if (Suma(i)==valoare)
            {
                return true;
            }
            return false;
        }
        private static int Suma(int i)
        {
            int s = 0;
            while (i != 0)
            {
                s = s + (i % 10);
                i /= 10;
            }
            return s;
        }
    }
}
