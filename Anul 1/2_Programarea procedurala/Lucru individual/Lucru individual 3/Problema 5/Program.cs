using System;

namespace Problema_5
{
    class Program
    {
        static int Sum(int[] t)
        {
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {/* Este dată mărime tabelară unidimensională A cu n elemente întregi.
            Determinați suma elementelor acestui tabel folosind o funcție ce primește tabelul ca parametru si reîntoarce suma elementelor.*/

            Console.WriteLine("Intruceti numarul de elemente");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Introduceti elementele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elementul {0} =", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma elementelor={0}", Sum(A));
            Console.ReadKey();
        }
    }
}
