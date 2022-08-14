using System;
using System.IO;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dându-se o matrice de numere întregi cu n linii și n coloane, să se verifice dacă este sau nu 
             matrice de adiacență asociată unui graf neorientat.
            Exemplu 1:
                Intrare
                4
                0 1 1 0 
                1 0 0 0
                1 0 0 1
                0 0 1 0
                Ieșire
                Este o matrice de adiacență asociată unui graf neorientat

            Exemplu 2:
                Intrare
                4
                0 1 1 0 
                1 0 0 0
                1 0 0 1
                0 0 0 0
                Ieșire
                Nu este o matrice de adiacență asociată unui graf neorientat
             */
            int[,] arr;
            using (StreamReader rd = new StreamReader("graf1.in"))//("graf2.in")
            {
                string[] ln = rd.ReadLine().Split(' ');
                int n = int.Parse(ln[0]);
                arr = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    ln = rd.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = int.Parse(ln[j]);
                    }
                }
            }
            if (IsAdiacent(arr))
            {
                Console.WriteLine("Este o matrice de adiacenta asociata unui graf neorientat");
            }
            else
            {
                Console.WriteLine("Nu este o matrice de adiacenta asociata unui graf neorientat");
            }
        }
        private static bool IsAdiacent(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]!=arr[j,i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
