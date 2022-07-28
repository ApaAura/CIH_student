using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int L, C, i, j;

            Console.Write("Numarul de linii ale matricei : ");
            L = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane ale matricei : ");
            C = int.Parse(Console.ReadLine());
            a = new int[L, C];

            Random R = new Random();
            for (i = 0; i < L; i++)
            {
                for (j = 0; j < C; j++)
                {
                    a[i, j] = R.Next(0, 100);
                }

            }

            Console.WriteLine("\n\nMatricea generata este:");
            for (i = 0; i < L; i++)
            {
                for (j = 0; j < C; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (i = 0; i < L; i++)
            {
                int aux = a[i, 1];
                a[i, 1] = a[i, 3];
                a[i, 3] = aux;
            }

            Console.WriteLine("\n\nMatricea dupa interschimbare este:");
            for (i = 0; i < L; i++)
            {
                for (j = 0; j < C; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
