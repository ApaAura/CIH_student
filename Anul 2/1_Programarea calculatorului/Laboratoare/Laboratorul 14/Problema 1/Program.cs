using System;

namespace Problema_1
{
    class Program
    {
        /*
         Se da un graf neorientat cu n noduri si m muchii. Afisati grupurile de muchii incidente.
        (Cele două noduri care formează o muchie sunt numite extremități ale muchiei, iar muchia este incidentă la noduri)
        Exemplu: 
        n=5 , m=4
        muchiile:
        [1,2]
        [1,3]
        [1,4]
        [3,4]
        grupurile de muchii incidente sunt: 
        [1,2] [1,3] [1,4]
        [3,1] [3,4]
        [4,1] [4,3]
         */
        static int n, m;
        static int[,] arr;
        static void Main(string[] args)
        {
            Console.Write("N =");
            n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            m = int.Parse(Console.ReadLine());
            arr = new int[100,100];
            int x, y;
            for (int i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                arr[x, y] = arr[y,x] = 1;
            }
            Console.WriteLine("grupurile de muchii incidente sunt");
            for (int i = 1; i <= n; i++)
            {
                if (grad(i) >= 2)
                {
                    for (int j = 1; j <= n; j++)
                        if (arr[i,j] == 1)
                            Console.Write($"[{i},{j}] ");
                    Console.WriteLine();
                }
            }
        }
        static int grad(int v)
        {
            int g = 0;
            for (int i = 1; i <= n; i++)
                g = g + arr[v,i];
            return g;
        }
    }
}
