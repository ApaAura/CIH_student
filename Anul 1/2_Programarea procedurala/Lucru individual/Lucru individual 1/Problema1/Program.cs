using System;
using System.IO;
using System.Linq;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Fişierul date.in conţine n numere întregi separate printr-un singur spaţiu. Primul număr
             reprezintă numărul de numere din fişier. Să se afişeze numărul minimal, maximal, numărul
             de elemente pare, impare şi media numerelor cu două zecimale. Rezultatul va fi afişat la
             ecran cât şi în fişierul date.out .
             */

            using (StreamWriter wr = new StreamWriter("date.in"))
            {
                Console.WriteLine("Dati numarul de elemente");
                int nr = int.Parse(Console.ReadLine());
                wr.WriteLine(nr);
                Random rd = new Random();
                for (int i = 0; i < nr; i++)
                {
                    wr.Write($"{rd.Next(0, 100)} ");
                }
            }
            using (StreamReader rd = new StreamReader("date.in"))
            {
                int nr = int.Parse(rd.ReadLine());
                string[] ln = rd.ReadLine().Split(" ");
                int[] mas = new int[nr];
                for (int i = 0; i < nr; i++)
                {
                    mas[i] = int.Parse(ln[i]);
                }
                int max = mas.Max(), min = mas.Min();
                double med = mas.Average();
                int countp = 0, counti = 0;
                for (int i = 0; i < nr; i++)
                {
                    if (mas[i]%2==0)
                    {
                        countp++;
                    }
                    else
                    {
                        counti++;
                    }
                }
                Console.WriteLine($"Max: {max}\nMin: {min}\nPare: {countp}\nImpare: {counti}\nMedia: {med:F2}");
                using (StreamWriter wr = new StreamWriter("date.out"))
                {
                    wr.Write($"Max: {max}\nMin: {min}\nPare: {countp}\nImpare: {counti}\nMedia: {med:F2}");
                }
            }
        }
    }
}
