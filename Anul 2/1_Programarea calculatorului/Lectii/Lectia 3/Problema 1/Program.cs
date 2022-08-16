using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        /*
         Citeste de la tastatura un numar natural n si afiseaza numarul
        bitilor din reprezentarea lui n in baza 2, apoi afiseaza bitii lui n.
         */
        static void Main(string[] args)
        {
            int n, num;
            Stack<int> stiva = new Stack<int>();
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            num = n;
            while (n>0)
            {
                stiva.Push(n % 2);
                n = n / 2;
            }
            Console.WriteLine($"Numarul {num} convertit in baza 2 are {stiva.Count} biti.");
            Console.Write($"Numarul {num} convertit in baza 2 este : ");
            while (stiva.Count>0)
            {
                Console.Write(stiva.Peek());
                stiva.Pop();
            }
            Console.ReadKey();
        }
    }
}
