using System;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linie;
            string[] el;
            Console.WriteLine("Introdu elementele multimii pe o linie separate prin spatiu: ");
            linie = Console.ReadLine();
            el = linie.Split(' ');
            n = el.Length;
            int[] ma = new int[n];
            for (int i = 0; i < n; i++)
            {
                ma[i] = int.Parse(el[i]);
            }
            Console.WriteLine("\nMultimea initiala: ");
            Afisare(ma);
            Bactracking(ma);
            Console.ReadKey();
        }
        private static void Bactracking(int[] ma)
        {
            int k = 0;
            int[] x = new int[ma.Length];
            int nrSol = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 0;
            }
            while (k>=0)
            {
                if (k==x.Length)
                {
                    ReturnSolutia(ma, x, ++nrSol);
                    k--;
                }
                else
                {
                    if (x[k]<x.Length)
                    {
                        x[k]++;
                        if (Continuare(x,k))
                        {
                            k++;
                        }
                    }
                    else
                    {
                        x[k--] = 0;
                    }
                }
            }
        }
        private static bool Continuare(int[] x, int k)
        {
            for (int i = 0; i < k; i++)
            {
                if (x[k]==x[i])
                {
                    return false;
                }
            }
            return true;
        }
        private static void ReturnSolutia(int[] ma, int[] x, int v)
        {
            Console.Write($"Permutarea {v}: ");
            for (int i = 0; i < ma.Length; i++)
            {
                Console.Write($"{ma[x[i]-1]} ");
            }
            Console.WriteLine("\n------------------------------------");
        }
        private static void Afisare(int[] ma)
        {
            foreach (var item in ma)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }
    }
}
