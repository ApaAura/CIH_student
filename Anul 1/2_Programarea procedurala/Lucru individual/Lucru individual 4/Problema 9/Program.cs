using System;
using System.IO;

namespace Problema_9
{
    class Program
    {
        static public string sir;
        static public int count = 0;
        static void Main(string[] args)
        {
            // Dintr-un fișier text se cetește un șir de caractere. Elaborați un program cu funcții/proceduri prin 
            // intermediul căruia se va determina numărul de consoane din acest șir.
            using (StreamReader rd = new StreamReader("fisier.txt"))
            {
                sir = rd.ReadLine();
            }
            NrConsoane();
        }
        private static void NrConsoane()
        {
            string consoane = "bcdfghjklmnpqrstvwxzy";
            for (int i = 0; i < sir.Length; i++)
            {
                if (consoane.Contains(sir.ToLower()[i]))
                {
                    count++;
                }
            }
            Console.WriteLine($"Sirul de caractere: {sir}");
            Console.WriteLine($"Sirul contine {count} consoane.");
        }
    }
}
