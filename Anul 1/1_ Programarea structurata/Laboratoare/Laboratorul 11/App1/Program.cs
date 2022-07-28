using System;

namespace App1
{
    class Program
    {
        /*
        Se dă un șir cu n elemente, numere naturale. Determinați diferența în valoare absolută dintre
        numărul de valori pare din șir și numărul de valori impare din șir.
        */
        static void Main(string[] args)
        {

            //Citirea datelor 
            int n = int.Parse(Console.ReadLine());
            string linie = Console.ReadLine();
            string[] element = linie.Split(' ');
            int[] tabel = new int[n];
            for (int i = 0; i < n; i++)
            {
                tabel[i] = int.Parse(element[i]);
            }
            /* 
            Citirea datelor aleatoriu 
            Random el = new Random ()
            for(int i=0; i<n; i++)
               {
                  tabel[i] = el.Next(100);
               }
            */
            int elementePare = 0, elementeImpare = 0;
            for (int i = 0; i < tabel.Length; i++)
            {
                if (tabel[i] % 2 == 0)
                {
                    elementePare++;
                }
                else
                {
                    elementeImpare++;
                }
            }
        
            int c = Math.Abs(elementePare - elementeImpare);
            /*
            Console.Write.Line(c);
            Console.ReadKey();
            */

            //Afisare rezultat
            Console.WriteLine("Tabelul Initial: ");
            for(int i=0; i<tabel.Length; i++) 
            {
                Console.Write("{0} ", tabel[i]);
            }
            Console.WriteLine($"\n|{elementePare}-{elementeImpare}| = {c}");
        }
    }
}
