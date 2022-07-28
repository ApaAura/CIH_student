using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declararea datelor initiale 
            int nr;
            Console.Write("Numarul de elemente: ");
            nr = int.Parse(Console.ReadLine());
            int[] tabel = new int[nr];

            //Completarea vectorului cu elemente generate aleator 
            Random el = new Random();
            for (int i = 0; i < nr; i++)
            {
                tabel[i] = el.Next(-100, 100);
            }

            //Afisarea vectorului 
            Console.WriteLine("Vectorul initial:");
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("0", tabel[i]);
            }

            //Algoritmul de rezolvare
            int max = tabel[0];
            int pozmax = 0;
            for (int i = 1; i < nr; i++)
            {
                if (max<tabel[i])
                {
                    max = tabel[i];
                    pozmax = i;
                }
            }
            //Afisam rezultatul problemei 
            Console.WriteLine("\nMaxim este: tabel[{0}]={1}", pozmax,max);
            Console.ReadKey();
        }
    }
}
