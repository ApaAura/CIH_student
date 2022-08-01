using System;
using System.IO;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fisierul date.in contine 12 numere intregi separate printr-un singur spatiu 
            care reprezinta temperaturile medii ale lunilor unui an, ca numere intregi.
            Sa se afiseze cu 2 zecimale media anuala a temperaturilor pozitive 
            si a rezultatelor negative.
            Rezultatul va fi afisar la ecran cat si in fisierul date.out
             */
            StreamReader fNumere = new StreamReader("date.in");
            string[] stNumere = fNumere.ReadLine().Split(" ");
            fNumere.Close();
            int[] temperatura = new int[12];
            for (int i = 0; i < 12; i++)
            {
                temperatura[i] = int.Parse(stNumere[i]);
            }
            int spozitive = 0, snegative = 0, npoz = 0, nneg = 0;
            double mpozitive, mnegative;
            for (int i = 0; i < 12; i++)
            {
                if (temperatura[i] > 0)
                {
                    npoz++;
                    spozitive += temperatura[i];
                }
                else
                {
                    nneg++;
                    spozitive += temperatura[i];
                }
            }
            mpozitive = (double)spozitive / npoz;
            mnegative = (double)snegative / nneg;
            Console.WriteLine($"Media negativa: {mnegative:F2}");
            Console.WriteLine($"Media pozitiva: {mpozitive:F2}");
            using(StreamWriter fRezultat= new StreamWriter("date.out"))
            {
                    fRezultat.WriteLine($"Media negativa: {mnegative:F2}");
                    fRezultat.WriteLine($"Media pozitive: {mpozitive:F2}");
            }
            Console.ReadKey();
            

        }
    }
}
