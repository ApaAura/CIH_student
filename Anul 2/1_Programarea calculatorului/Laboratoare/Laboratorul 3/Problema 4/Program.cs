using System;
using System.Collections.Generic;

namespace Problema_4
{
    /*
     De creat o structură de tip stivă cu n elemente numere întregi ce sunt generate în mod aleator. Să se calculeze 
    produsul elementelor impare din stivă. La ecran să se afișeze elementele stivei și rezultatul obținut. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                masiv[i] = el.Next(1,100);
            }
            Console.WriteLine("Elementele generate:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(masiv[i]+" "); 
            }
            int prodImpare = 1;
            Stack<int> NumImpare = new Stack<int>();
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i]%2==1)
                {
                    NumImpare.Push(masiv[i]);
                    prodImpare *= masiv[i];
                }
            }
            Console.WriteLine("\nStiva elementelor impare: ");
            AfisareStiva(NumImpare);
            Console.WriteLine($"\nProdusul elementelor impare:  {prodImpare}");
        }
        private static void AfisareStiva(Stack<int> stiva)
        {
            foreach (int i in stiva)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
