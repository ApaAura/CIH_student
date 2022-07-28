using System;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[][] a;
            int[] t;

            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            t = new int[n];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                t[i] = r.Next(1, 10);
            }

            a = new int[n][];
            for (i = 0; i < n; i++)
            {
                a[i] = new int[t[i]];
                for (j = 0; j < t[i]; j++)
                {
                    a[i][j] = r.Next(0, 30);
                }
            }

            foreach (int[] v in a)
            {
                foreach (int elem in v)
                    Console.Write(elem + " ");
                Console.WriteLine();
            }
        }
    }
}
