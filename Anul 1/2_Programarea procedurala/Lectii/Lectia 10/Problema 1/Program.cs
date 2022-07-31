using System;

namespace Problema_1
{
    class Program
    {
        static int n, k;
        static int[] st = new int[20];
        static void Main(string[] args)
        {
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            st[0] = 0;
            Btk(1);
            Console.ReadKey();
        }
        private static void Btk(int p)
        {
            for (int val = st[p-1]+1; val <= n; val++)
            {
                st[p] = val;
                if (Solutie(p))
                {
                    Tipar(p);
                }
                else
                    Btk(p + 1);
            }
        }
        private static void Tipar(int p)
        {
            for (int i = 0; i <= p; i++)
            {
                Console.Write($"{st[i]} ");
            }
            Console.WriteLine();
        }
        //Trebuie de adaugat functia Solutie 
        private static bool Solutie(int p)
        {
            throw new NotImplementedException();
        }
    }
}
