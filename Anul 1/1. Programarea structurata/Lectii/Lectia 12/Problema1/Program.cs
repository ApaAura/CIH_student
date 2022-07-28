using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[,] matrice = new int[,] {
                 { 2,3,4,5},
                 { 3,5,1,3},
                 { 1,2,4,6},
             };
             */
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int[,] matrice = new int[n, m];
            Random el = new Random();
            Console.WriteLine("Introdu elementele matricei:");
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = el.Next(0,100);
                }
              
            }

            Console.WriteLine("Tabel bidimensional:");
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.WriteLine( "{0}",matrice[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
