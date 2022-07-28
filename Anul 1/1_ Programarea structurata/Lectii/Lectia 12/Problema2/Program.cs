using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 } };
            //int[,] a = new int[3, 4] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 } };
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write("{0} ", a[i, j]);
                Console.WriteLine();
            }
        }
    }
}
