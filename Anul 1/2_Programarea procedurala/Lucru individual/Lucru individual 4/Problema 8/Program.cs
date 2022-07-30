using System;
using System.IO;

namespace Problema_8
{
    class Program
    {
        static public string sir;
        static public int count = 0;
        static void Main(string[] args)
        {
            // Dintr-un fișier text se cetește un șir de caractere. Elaborați un program cu funcții/proceduri 
            // prin intermediul căruia se va determina numărul de vocale din acest șir.
            using (StreamReader rd = new StreamReader("fisier.txt"))
            {
                sir = rd.ReadLine();
            }
            Console.WriteLine($"Sirul de caractere: {sir}");
            Console.WriteLine($"Sirul contine {NrVocale()} vocale.");
        }
        private static int NrVocale()
        {
            string consoane = "aeiou";
            for (int i = 0; i < sir.Length; i++)
            {
                if (consoane.Contains(sir.ToLower()[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
