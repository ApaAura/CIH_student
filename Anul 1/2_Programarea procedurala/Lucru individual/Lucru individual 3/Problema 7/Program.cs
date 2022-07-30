using System;
using System.Linq;

namespace Problema_7
{
    class Program
    {
        static int Max(int[] t)
        {
            int max = t.Max();
            return max;
        }
        static void Main(string[] args)
        {/* Este dată mărime tabelară unidimensională A cu n elemente întregi.
            Determinați elementul maximal al acestui tabel folosind o funcție ce primește tabelul ca parametru si reîntoarce valoarea determinată.*/
            Console.WriteLine("Intruceti numarul de elemente");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Introduceti elementele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elementul {0} =", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elemntul maxim:{0}", Max(A));
            Console.ReadKey();
        }
    }
}
