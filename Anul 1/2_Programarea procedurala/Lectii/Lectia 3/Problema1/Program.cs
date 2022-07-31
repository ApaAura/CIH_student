using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmul de sortare prin metoda bulelor:
            int n, aux;
            bool gasit;
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
            //Sortarea crescatoare
            do
            {
                gasit = false;
                for (int i = 0; i < n-1; i++)
                {
                    if (vector[i]>vector[i+1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                        gasit = true;
                    }
                }
            } while (gasit==true);
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
