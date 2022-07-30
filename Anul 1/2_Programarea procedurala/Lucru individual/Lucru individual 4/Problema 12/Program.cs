using System;

namespace Problema_12
{
    class Program
    {
        static public int[] masiv;
        static public int countPare = 0;
        static public int suma = 0;
        static void Main(string[] args)
        {
            // Este dată mărime tabelară unidimensională A cu n elemente întregi. Determinați numărul elementelor pare 
            // ale acestui tabel folosind o procedură ce primește tabelul ca parametru si reîntoarce suma elementelor.
            
            Console.Write("Introdueti numarul de elemente: ");
            int nr = int.Parse(Console.ReadLine());
            masiv = Citire(nr);
            Afisare(masiv);
            elPare(masiv);
        }
        private static void elPare(int[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i]%2==0)
                {
                    countPare++; 
                    suma += masiv[i];
                }
            }
            Console.WriteLine($"Tabelul inidimensional are {countPare} elemente pare.");
            Console.WriteLine($"Suma elementor tabelului este {suma}");
        }
        private static void Afisare(int[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i]+ " ");
            }
            Console.WriteLine();
        }
        private static int[] Citire(int nr)
        {
            int[] mas = new int[nr];
            Random el = new Random();
            for (int i = 0; i < nr; i++)
            {
                mas[i]=el.Next(-100, 100);
            }
            return mas;
        }
    }
}
