using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            List<int> multimeaA = new List<int>();
            List<int> multimeaB = new List<int>();
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                multimeaA.Add(el.Next(-100, 100));
            }
            Console.WriteLine("Elementele multimii A:");
            Afisare(multimeaA);
            int s = 0;
            SolutieGreedy(multimeaA, n, ref multimeaB, m, ref s);
            Console.WriteLine("\nElementele multimii B:");
            Afisare(multimeaB);
            Console.WriteLine($"\n sumaMaxima = {s}");
            Console.ReadKey();
        }
        private static void SolutieGreedy(List<int> multimeaA, int n, ref List<int> multimeaB, int m, ref int s)
        {
            multimeaA.Sort();
            multimeaA.Reverse();
            s = 0;
            for (int i = 0; i < m; i++)
            {
                multimeaB.Add(multimeaA[i]);
                s += multimeaB[i];
            }
        }
        private static void Afisare(List<int> multimeaA)
        {
            foreach (int i in multimeaA)
            {
                Console.Write($"{i}");
            }
        }
    }
}
