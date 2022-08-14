using System;

namespace Problema_4
{
    class Program
    {
        /*
         Se citeste un vector cu n elemente numere naturale. Sa se calculeze
         CMMDC al elementelor vectorului folosind divide et impera.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n+1];
            for (int i = 1; i <= n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("Elementele vectorului: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(vector[i]+" ");
            }
            Console.WriteLine("\nCMMDC al elementelor: "+ cmmdc(vector, 1, n));
            Console.ReadKey();
        }
        private static int cmmdc(int[] vector, int left, int right)
        {
            if (left==right)
            {
                return vector[left];
            }
            else
            {
                int x, y;
                x = cmmdc(vector, left, (left + right) / 2);
                y = cmmdc(vector, (left + right) / 2+1, right);
                while (x!=y)
                {
                    if (x>y)
                    {
                        x = x - y;
                    }
                    else
                    {
                        y = y - x;
                    }
                }
                return x;
            }
        }
    }
}
