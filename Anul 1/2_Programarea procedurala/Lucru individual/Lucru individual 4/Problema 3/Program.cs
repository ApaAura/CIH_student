using System;

namespace Problema_3
{
    class Program
    {
        public static string text;
        static void Main(string[] args)
        {
            //Elaborați un program care va determina numărul de vocale dintr-un 
            // șir de caractere cu ajutorul unei proceduri ce primește acest șir ca parametru.
            Console.WriteLine("Introduceti un sir de caractere: ");
            text = Console.ReadLine();
            NrVocale(text);
        }
        private static void NrVocale(string text)
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
            Console.WriteLine($"Sirul de caractere contine {nrV} vocale");
        }
    }
}
