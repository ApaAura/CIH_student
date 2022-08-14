using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        /*
        Sa se formeze o lista simplu inlantuita formata din elemente aflate pe 
       diagonala principala a unei matrice cu n linii si n coloane.
        */
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii si coloane: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matrice = new int[N, N];
            Random el = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrice[i, j] = el.Next(0, 100);
                }
            }
            Console.WriteLine("Elementele matricei: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrice[i,j]+" ");
                }
            }
            List<int> diagonala = new List<int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrice[i,j]==matrice[i,i])
                    {
                        diagonala.Add(matrice[i,j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nElementele pozitionate pe diagonala principala: ");
            foreach (int i in diagonala)
            {
                Console.Write(i+" ");
            }
        }
    }
}
