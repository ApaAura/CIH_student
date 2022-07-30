using System;

namespace Problema_13
{
    class Program
    {
        static public int[] masiv;
        static public int countImp = 0;
        static public int suma = 0;
        static void Main(string[] args)
        {
            // Este dată mărime tabelară unidimensională A cu n elemente întregi. Determinați numărul 
            // elementelor impare ale acestui tabel folosind o funcți ce primește tabelul ca parametru si reîntoarce suma elementelor.

            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            masiv = Citire(n);
            Afisare();
            int suma = elImpare(masiv);
            Console.WriteLine($"Tabelul unidimensional are {countImp} elemente impare.");
            Console.WriteLine($"Suma elementelor tabelului este {suma}.");
        }
        private static int elImpare(int[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] % 2 == 1)
                {
                    countImp++;
                    suma += masiv[i];
                }
            }
            return suma;
        }
        private static void Afisare()
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i]+" ");
            }
            Console.WriteLine();
        }
        private static int[] Citire(int n)
        {
            int[] m = new int[n];
            Random numar = new Random();
            for (int i = 0; i < n; i++)
            {
                m[i] = numar.Next(-100, 100);
            }
            return m;
        }
    }
}
