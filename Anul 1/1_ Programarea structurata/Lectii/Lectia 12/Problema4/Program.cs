using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int n, i, j;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\n\nMatricea citita este:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] < 0 || a[i, j] > 1)
                    {
                        Console.WriteLine("Matricea nu este binara");
                        return;
                    }
                    if (a[i, j] != a[j, i])
                    {
                        Console.WriteLine("Matricea nu este simetrica");
                        return;
                    }
                }
            for (i = 0; i < n; i++)
                if (a[i, i] != 0)
                {
                    Console.WriteLine("Matricea nu are doar valori 0 pe diagonala principala");
                    return;
                }
            Console.WriteLine("Este matrice de adiacenta");
        }
    }
}
