using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmul de sortare prin metoda bulelor:
            int n;
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
            int aux;
            for (int i = 0; i < vector.Length-1; i++)
            {
                for (int j = i+1; j < vector.Length; j++)
                {
                    if (vector[i]>vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
            Console.WriteLine("\n Tabelul sortat: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadKey();
        }
    }
}
