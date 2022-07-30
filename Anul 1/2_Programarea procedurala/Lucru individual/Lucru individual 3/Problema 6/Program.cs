using System;
using System.Linq;

namespace Problema_6
{
    class Program
    {
        static void Sum(int[] t)
        {
            Console.WriteLine(t.Sum());
        }
        static void Main(string[] args)
        {/* Este dată mărime tabelară unidimensională A cu n elemente întregi. 
            Determinați suma elementelor acestui tabel folosind o procedură ce primește tabelul ca parametru si reîntoarce suma elementelor.*/

            Console.WriteLine("Intruceti numarul de elemente");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Introduceti elementele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elementul {0} =", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Suma elementelor=");
            Sum(A);
            Console.ReadKey();
        }
    }
}
