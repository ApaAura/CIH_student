using System;
using System.Collections.Generic;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Studenti = new List<Student>();
            Console.Write("Numarul de studenti: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Datele despre studentul: {i+1}");
                Student studentNew = new Student();
                studentNew.Citire();
                Studenti.Add(studentNew);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista tuturor studentilor: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDatele despre studentul {i + 1}");
                Studenti[i].Afisare();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista studentilor restantieri: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                if (Studenti[i].Restanta()==1)
                {
                    Console.WriteLine($"\nDatele despre studentul {i + 1}");
                    Studenti[i].Afisare();
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista studentilor care au bursa: ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                if (Studenti[i].Bursa()==500)
                {
                    Console.WriteLine($"\nDatele despre studentul {i + 1}");
                    Studenti[i].Afisare();
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista studentilor cu o varsta mai mica decat 18 ani");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                if (Studenti[i].Varsta() <18)
                {
                    Console.WriteLine($"\nDatele despre studentul {i + 1}");
                    Studenti[i].Afisare();
                }
            }

        }
    }
}
