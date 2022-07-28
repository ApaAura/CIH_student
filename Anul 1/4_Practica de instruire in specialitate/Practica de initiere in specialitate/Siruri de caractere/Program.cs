using System;

namespace Siruri_de_caractere
{
    class Program
    {
        static public string text;
        static public string invers;
        static void Main(string[] args)
        {
             Console.WriteLine("Introduceti un sir de caractere: ");
             text = Console.ReadLine();
             invers = Inversare(text, text.Length - 1);
             Verificare(text);
        }
        private static void Verificare(string text)
        {
            if (text!=invers)
            {
                Console.WriteLine($"Sirul '{text}' nu este palidrom.");
            }
            else
            {
                Console.WriteLine($"Sirul '{text}' este palidrom.");
            }
        }
        static public string Inversare(string sir, int length)
        {
            if (length == -1) return "";
            else
            {
                return sir[length] + Inversare(sir, length - 1);
            }
        }
    }
}
