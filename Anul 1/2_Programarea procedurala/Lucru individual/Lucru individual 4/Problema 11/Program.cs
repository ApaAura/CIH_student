using System;

namespace Problema_11
{
    class Program
    {
        static public int[] masiv;
        static public int suma = 0;
        static void Main(string[] args)
        {
            //  Este dată mărime tabelară unidimensională A cu n elemente întregi. Determinați suma elementelor impare ale acestui tabel 
            //  folosind o funcție ce primește tabelul ca parametru si reîntoarce suma elementelor.
            Console.Write("Introducei numarul de elemente:  ");
            int nr = int.Parse(Console.ReadLine());
            masiv = Citire(nr);
            Afisare();
            Console.WriteLine($"Suma elementelor impare este {SumaImp(masiv)}");
        }
        private static int SumaImp(int[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i]%2==1)
                {
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
        private static int[] Citire(int nr)
        {
            int[] m = new int[nr];
            Random el = new Random();
            for (int i = 0; i < nr; i++)
            {
                m[i] = el.Next(-100, 100);
            }
            return m;
        }
    }
}
