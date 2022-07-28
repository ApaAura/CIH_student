using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citirea datelor initiale
            int n = int.Parse(Console.ReadLine());
            int[] tabel = new int[n];

            string linie = Console.ReadLine();
            string[] element = linie.Split(' ');
            for (int i=0; i < n; i++)
            {
                tabel[i] = int.Parse(element[i]);
            }
            /*
            Citirea datelor aleatoriu 
            Random el = new Random ()
            for(int i-=0; i<n; i++)
               {
                  tabel[i] = el.Next(100);
               }
            */

            //Algoritmul de prelucrare a tabelului 
            int min = tabel[0];
            int max = tabel[0];
            for (int i = 1; i < tabel.Length; i++)
            {
                if (min > tabel[i])
                {
                    min = tabel[i];
                }
                if (max < tabel[i])
                {
                    max = tabel[i];
                }
            }
            //Console.WriteLine("{0} {1}", min, max);
            //Afisare rezultat
            Console.WriteLine("Tabelul Initial: ");
            for (int i = 0; i < tabel.Length; i++)
            {
                Console.Write("{0} ", tabel[i]);
            }
            Console.WriteLine("\nminim = {0}\nmaxim = {1}", min, max);
        }
    }
}
