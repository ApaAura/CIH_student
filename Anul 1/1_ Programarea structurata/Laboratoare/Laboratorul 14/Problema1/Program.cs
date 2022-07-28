using System;
using System.Text;

namespace Problema1
{
    class Program
    {
        private static object stringBuilder;

        static void Main(string[] args)
        {
            /*
             Elaborați un program de consolă ce va insera după fiecare simbol x 
            citit de la tastatură simbolul y citit de la tastatura în textul s.
            */
            //Citirea datelor de la tastatura
            Console.WriteLine("Introdu textul:");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Console.Write("caracterul cautat x= ");
            char x = char.Parse(Console.ReadLine());
            Console.Write("caracterul inserat y= ");
            char y = char.Parse(Console.ReadLine());

            //Algoritmul de rezolvare
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==x)
                {
                    s.Insert(i + 1, y);
                    i++;
                }
            }

            //Afisarea rezultatului
            Console.WriteLine("Textul modificat:\n{0}",s);
            Console.ReadKey();

        }
    }
}
