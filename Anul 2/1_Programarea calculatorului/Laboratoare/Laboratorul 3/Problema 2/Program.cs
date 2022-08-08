using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        /*
         De la tastatură se vor introduce n numere întregi. De elaborat o aplicație ce va
         crea două stive din aceste numere, una doar cu numere pare alta numai cu numere impare. 
         Să se afișeze la ecran conținutul acestor stive și numărul de numere pare și impare din șirul introdus.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            Console.WriteLine($"Introduceti {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Stack<int> numPare = new Stack<int>();
            Stack<int> numImpare = new Stack<int>();
            int countPare = 0;
            int countImpare = 0;
            foreach (int i in masiv)
            {
                if (i%2==0)
                {
                    numPare.Push(i);
                    countPare++;
                }
                else
                {
                    numImpare.Push(i);
                    countImpare++;
                }
            }
            Console.WriteLine($"Stiva cu elemente pare - {countPare} elemente: ");
            AfisareStiva(numPare);
            Console.WriteLine($"\nStiva cu elemente impare - {countImpare} elemente:: ");
            AfisareStiva(numImpare);
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
