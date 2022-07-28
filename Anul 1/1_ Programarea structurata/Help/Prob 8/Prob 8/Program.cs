using System;

namespace Prob_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este dată o matrice n x n elemente. Să se determine elementul minimal din această matrice.
            Console.WriteLine("Introduceti dimensiunile matricii");
            Console.WriteLine("Introduceti N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrice = new int[n, m];
            //generam aleatoriu elementele
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrice[i, j] = el.Next(0, 100);
                }
            }
            Console.WriteLine("Elementele matricii: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrice[i,j]+" ");
                }
            }
            int Min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrice[i,j]<Min)
                    {
                        Min = matrice[i, j];
                    }
                }
            }
            Console.WriteLine("\nElementul minim: {0}", Min);

        }
    }
}
