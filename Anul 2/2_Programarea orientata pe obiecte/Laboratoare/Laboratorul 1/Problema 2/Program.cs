using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Angajat> angajati = new List<Angajat>();
            Console.WriteLine("Introduceti numarul de angajati: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDatele despre angajatul {i+1}");
                Angajat angajat = new Angajat();
                angajat.Citire();
                angajati.Add(angajat);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Angajati inregistrati: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDatele despre angajatul {i+1}");
                angajati[i].Afisare();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Angajati cu stagiul mai mare de 10 ani: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDatele despre angajatul {i + 1}");
                if (angajati[i].Stagiu()>10)
                {
                    angajati[i].Afisare();
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Angajati cu stagiul mai mare de 10 ani: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDatele despre angajatul {i + 1}");
                if (angajati[i].SalariuPrimit()>1000)
                {
                    angajati[i].Afisare();
                }
            }
        }
    }
}
