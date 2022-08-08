using System;
using System.Collections.Generic;

namespace Problema_3
{
    /*
    De la tastatură se introduce un text. Din cuvintele acestui text să se formeze două stive, 
    una cu cuvintele ce se încep cu o vocală, alta cu cuvintele ce se încep cu o consoană. Să se 
    afișeze la ecran conținutul acestor stive și numărul de cuvinte din ele.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Introduceti textul: ");
            text = Console.ReadLine();
            string[] cuvinte = text.Split(' ');
            Stack <string> cuvVocale= new Stack<string>();
            Stack<string> cuvConsoane = new Stack<string>();
            int countCuvVocale = 0;
            int countCuvConsoane = 0;
            string vocale = "aeiouAEIOU";
            for (int i = 0; i < cuvinte.Length; i++)
            {
                if (vocale.Contains(cuvinte[i][0]))
                {
                    cuvVocale.Push(cuvinte[i]);
                    countCuvVocale++;
                }
                else
                {
                    cuvConsoane.Push(cuvinte[i]);
                    countCuvConsoane++;
                }
            }
            Console.WriteLine($"Stiva cu elemente cuvinte ce incep cu vocale - {countCuvVocale} elemente: ");
            AfisareStiva(cuvVocale);
            Console.WriteLine($"\nStiva cu elemente cuvinte ce incep cu consoane - {countCuvConsoane} elemente: ");
            AfisareStiva(cuvConsoane);
        }
        private static void AfisareStiva(Stack<string> stiva)
        {
            foreach (string i in stiva)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
