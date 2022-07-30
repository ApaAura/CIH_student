using System;
using System.Linq;

namespace Problema_8
{
    class Program
    {
        static void Min(int[] t)
        {
            Console.WriteLine("Elementul minim:{0}", t.Min());
        }
        static void Main(string[] args)
        {/*	Este dată mărime tabelară unidimensională A cu n elemente întregi.
            Determinați elementul minimal al acestui tabel folosind o procedură ce primește tabelul ca parametru si reîntoarce valoarea determinată.*/

            Console.WriteLine("Intruceti numarul de elemente");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Introduceti elementele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elementul {0} =", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Min(A);
            Console.ReadKey();
        }
    }
}
