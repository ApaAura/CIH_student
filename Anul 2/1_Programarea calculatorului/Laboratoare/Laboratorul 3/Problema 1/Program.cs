using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        /*
         Este dat un text. Sa se formeze din cuvintele acestui text, 2 stive, prima stiva va contine
        cuvintele ce au lungime amai mare de 6 caractere, a 2 stiva cuvintele ce au lungimea mai mica de 6 caractere
         */
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Introduceti textul: ");
            text = Console.ReadLine();
            string[] cuvinte = text.Split(' ');
            Stack<string> stivaCuvinteMare = new Stack<string>();
            Stack<string> stivaCuvinteMica = new Stack<string>();
            for (int i = 0; i < cuvinte.Length; i++)
            {
                if (cuvinte[i].Length > 6)
                {
                    stivaCuvinteMare.Push(cuvinte[i]);
                }
                else 
                {
                    stivaCuvinteMica.Push(cuvinte[i]);
                }
            }
            Console.WriteLine("Stiva cu cuvinte ce au lungimea mai mica de 6 caractere: ");
            AfisareStiva(stivaCuvinteMica);
            Console.WriteLine("\nStiva cu cuvinte ce au lungimea mai mare de 6 caractere: ");
            AfisareStiva(stivaCuvinteMare);
            Console.ReadKey();
        }
        private static void AfisareStiva(Stack<string> stiva)
        {
            foreach (string item in stiva)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
