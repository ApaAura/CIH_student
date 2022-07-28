
using System;

namespace lectiedeevaluarenr3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Este dat un vector cu n elemente întregi, generate în mod aleator din intervalul -100, 100. 
            Să se determine suma elementelor impare din acest vector
             */
            int nr;//numarul de elemente ale tabelului.
            Console.WriteLine("Introdu numarul de elemente:");
            nr = int.Parse(Console.ReadLine());
            int[] tabel = new int[nr];
            int sumaImpare = 0;
            Random numar = new Random();
            for (int i = 0; i < nr; i++) 
            {
                tabel[i] = numar.Next(-100, 100); //numere aleatorii din intervalul -100,100
                if (tabel[i] % 2 == 1)
                {
                    sumaImpare += tabel[i];
                }
            }
            Console.WriteLine("Vectorul:"); //Afisarea vectorului
            for (int i = 0; i < nr; i++)
            {
                Console.Write("{0} ", tabel[i]);
            }
            //Afisarea rezultatului
            Console.WriteLine("\nSuma numerelor impare este: {0}", sumaImpare);
        }
    }
}
