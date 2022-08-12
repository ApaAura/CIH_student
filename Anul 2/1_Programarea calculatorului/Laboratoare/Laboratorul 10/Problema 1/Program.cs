using System;

namespace Problema_1
{
    class Program
    {
        /*
         Considerandu-se o tabla de sah de dimnesiune NxN sa se determine
         toate modalitatile de amplasare a n regiune pe tabla de sah astfel
         incat sa nu se atace doua cate doua. Implementare recursiva.
         */
        static int n;
        static int nr;
        static int[] x = new int[20];
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    nr = 0;
                    BackRecursiv(1);
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare !");
                    isValid = false;
                }
            }
        }
        private static void BackRecursiv(int k)
        {
            for (int j = 1; j <= n; j++)
            {
                x[k] = j;
                if (Valid(k)==1)
                {
                    if (k<n)
                    {
                        BackRecursiv(k + 1);
                    }
                    else
                    {
                        nr++;
                        Console.WriteLine($"Solutia {nr}");
                        for (int i = 1; i <= n; i++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (x[i]==p)
                                {
                                    Console.Write("D ");
                                }
                                else
                                {
                                    Console.Write("* ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        private static int Valid(int k)
        {
            for (int p = 0; p <= k-1; p++)
            {
                if ((x[k]==x[p])|(Math.Abs(k-p)==Math.Abs(x[k]-x[p])))
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
