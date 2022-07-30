using System;

namespace Problema_2
{
    class Program
    {
        static public string text;
        static void Main(string[] args)
        {
            // Elaborați un program care va determina numărul de vocale dintr-un 
            // șir de caractere cu ajutorul unei funcții ce primește acest șir ca parametru.
            Console.WriteLine("Introduce un sir de caractere: ");
            text = Console.ReadLine();
            Console.WriteLine($"Sirul de caractere contine {NrVocale(text)} vocale.");
        }
        private static object NrVocale(string text)
        {
            string vocale = "aeiou";
            int nrV = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (vocale.Contains(text.ToLower()[i]))
                {
                    nrV++;
                }
            }
            return nrV;
        }
    }
}
