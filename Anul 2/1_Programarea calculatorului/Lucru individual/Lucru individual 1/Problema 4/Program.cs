using System;
using System.Collections.Generic;

namespace Problema_4
{
    class Program
    {
        /*
         De la tastatură se vor introduce n numere întregi. Să se calculeze produsul 
        elementelor impare din stivă. La ecran să se afișeze elementele stivei și rezultatul obținut.
         */
        static void Main(string[] args)
        {
            Stack<int> list = new Stack<int>();
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                list.Push(m);
            }
            int prod = 1;
            foreach (int i in list)
            {
                if (i%2==1)
                {
                    prod *= i;
                }
            }
            Console.Clear();
            Console.WriteLine("Elementele stivei: ");
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            if (prod==1)
            {
                Console.WriteLine("\nStiva nu are elemente impare.");
            }
            else
            {
                Console.WriteLine($"\nProdusul elementelor impare: {prod}");
            }
        }
    }
}
