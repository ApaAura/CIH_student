using System;
using System.Text;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Va șterge din textul dat un character x citit de la tastastură.
            //Citirea datelor de la tastatura 
            Console.WriteLine("Introduceti textul:");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Caracterul cautat x:");
            char x = char.Parse(Console.ReadLine());

            //Algoritmul de rezolvare
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == x)
                {
                    s.Remove(i, 1);
                }
            }
            //Afisarea rezultatului 
            Console.WriteLine("Textul modificat:\n{0}", s);
            Console.ReadKey();
        }
    }
}
