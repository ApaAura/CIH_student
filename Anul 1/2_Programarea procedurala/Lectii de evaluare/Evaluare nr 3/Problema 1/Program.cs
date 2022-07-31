using System;

namespace Problema_1
{
    class Program
    {
        static int n = 0;
        static int[,] arr = new int[100,100];
        static void Main(string[] args)
        {
            // Subgrupa 1: Se dă matricea de adiacenta unui graf neorientat. 
            //Să se afișeze nodurile de grad maxim.
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti valorile matricei: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = 0;
                }
            }
            int x, y;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x{i} = "); x = int.Parse(Console.ReadLine());
                Console.Write($"y{i} = "); y = int.Parse(Console.ReadLine());
                arr[x, y] = arr[y, x] = 1;
            }
            int gradMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (grad(i)>gradMax)
                {
                    gradMax = grad(i);
                }
            }
            Console.WriteLine("Nodurile de grad maxim:");
            for (int i = 0; i < n; i++)
            {
                if (grad(i)==gradMax)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        static int grad(int v)
        {
            int g = 0;
            for (int i = 1; i <= n; i++)
                g = g + arr[v, i];
            return g;
        }
    }
}
