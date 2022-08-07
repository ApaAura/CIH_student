using System;
using System.Text;

namespace pppppppppp
{
    class Program
    {
        public static StringBuilder sir;
        static void Main(string[] args)
        {
            Citire();
            Verificare();
            Afisare();
            Console.ReadKey();
        }
        private static void Afisare()
        {
            Console.WriteLine($"Textul modificat:\n{sir}");
        }
        private static void Verificare()
        {
            sir = sir.Replace('d', String.Empty);
            for (int i = 0; i < sir.Length; i++)
            {
                if (sir[i] == 'd')
                {
                    sir.Remove(i, 1);
                }
                if (sir[i] == 'D')
                {
                    sir.Remove(i, 1);
                }
            }
        }
        private static void Citire()
        {
            Console.WriteLine("Introduceti un sir de caractere: ");
             sir = new StringBuilder(Console.ReadLine());
        }
    }
}
