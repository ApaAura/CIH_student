using System;

namespace Prob_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Este dat un tabel unidimensional cu n elemente întregi, generate în mod 
              aleatoriu. Să se determine elementul maximal de pe pozițiile impare. Să se afișeze la 
              ecran elementul obținut.
             */
            Console.WriteLine("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());
            int[] tabel = new int[n];
            //generam aleatoriu elementele
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                tabel[i] = el.Next(0, 100);
            }
            //Afisarea elementelor
            Console.WriteLine("Elementele tabelului: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(tabel[i]+" ");
            }
            int max = int.MinValue;
            //pozitii impare     for (int i = 0; i < n; i+=2)
            //pozitii pare       for (int i = 1; i < n; i+=2)
            for (int i = 0; i < n; i+=2)
            {
                if (tabel[i]>max)
                {
                    max = tabel[i];
                }
            }
            Console.WriteLine("\nElementul maxim de pe pozitiile impare: {0}",max);
        }
    }
}
