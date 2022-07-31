using System;
using System.IO;

namespace Problema_1
{
    
    class Program
    {
        const int nmax = 20;
        public static int[] b = new int[nmax];
        public static int n, k;
        static void Main(string[] args)
        {
            using (StreamWriter wr = new StreamWriter("date.out"))
            {
                wr.WriteLine("Solutiile obtinute: ");
            }
                int r;
                Console.Write("Introduceti n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Introduceti k: ");
                k = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    b[i] = 0;
                }
                do
                {
                    r = Numar();
                    if (r>=k)
                    {
                        Scrie();
                    }
                    if (r<n)
                    {
                        Urmator(ref b);
                    }
                } while (r!=n);
                 Console.ReadKey();
        }
        private static void Urmator(ref int[] x)
        {
            int j = n;
            while (x[j]==1)
            {
                x[j] = 0;
                j--;
            }
            x[j] = 1;
        }
        private static void Scrie()
        {
            using (StreamWriter wr=new StreamWriter("date.out", append:true))
            {
                for (int i = 0; i < n; i++)
                {
                    wr.Write($"{b[i]}, ");
                }
                wr.WriteLine();
            }
        }
        private static int Numar()
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += b[i];
            }
            return s;
        }
    }
}
