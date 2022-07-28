using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 2: Se dau numerele naturale m și n, unde m < n 
             Să se calculeze produsul numerelor mai mici decât n, divizibile cu m.
             */
            Console.Write("Indruduceti valoarea m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Indruduceti valoarea n: ");
            int n = int.Parse(Console.ReadLine());

            if ((m<n)&&(m>0)&&(n>0))
            {
                int produs=1;
                for (int i = 1; i < n; i++)
                {
                    if (i % m == 0)
                    {
                        produs *= i;
                    }
                }
                Console.WriteLine($"Produsul numerelor mai mici ca {n} divizibile la {m} este: {produs} ");
            }
            else
                Console.WriteLine("Nu se poate determina");
            Console.ReadKey();
        }
    }
}
