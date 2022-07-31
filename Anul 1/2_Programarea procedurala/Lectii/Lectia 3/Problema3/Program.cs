using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sortarea crescatoare prin metoda insertiei
            int n, aux;
            int j;
            Console.WriteLine("Numarul de elemente: ");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            //Declararea si completarea vectorului
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Vector[{i}]=");
                vector[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                aux = vector[i];
                j = i - 1;
                while (j>=0 && vector[j]>aux)
                {
                vector[j + 1] = vector[j];
                j--;
                }
                vector[j + 1] = aux;
            }
            //Afisarea vectorului sortat
            Console.WriteLine("Vectorul sortat crescator:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vector[i]}");
            }
            Console.ReadKey();
        }
    }
}
