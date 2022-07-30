using System;
using System.IO;

namespace Problema_7
{
    class Program
    {
        static public string text;
        static public string a;
        static void Main(string[] args)
        {
            // Dintr-un fișier text se cetește un șir de caractere. Elaborați un program cu funcții/proceduri prin
            // intermediul căruia se va determina dacă acest șir este palindrom (se citește la fel de la stînga la dreapta și dreapta la stînga).
            using (StreamReader rd = new StreamReader("fisier.txt"))
            {
                text=rd.ReadLine();
            }
            a = Inversare(text, text.Length-1);
            Verificare(text);
        }
        private static void Verificare(string text)
        {
            if (text==a)
                Console.WriteLine($"Sirul \"{text}\" este palindrom.");
            else
                Console.WriteLine($"Sirul \"{text}\" nu este palindrom.");
        }
        private static string Inversare(string text, int length)
        {
            if (length == -1) return "";
            else 
            {
                return text[length] + Inversare(text, length - 1);
            }
        }
    }
}
