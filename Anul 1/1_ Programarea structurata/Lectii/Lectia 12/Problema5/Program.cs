using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] a;

            a = new int[3][]
            {
        new int[]{ 1, 1, 1 }, // initializare prima linie 
		new int[]{ 2, 2, 2, 2, 2 }, // initializare a doua linie 
		new int[]{ 3, 3, 3, 3 } // initializare a treia linie
            };

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
