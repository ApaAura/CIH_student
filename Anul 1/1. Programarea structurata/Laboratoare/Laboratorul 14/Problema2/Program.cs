using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Elaborați o aplicație de consolă ce va determina de cite ori
             se întîlnește într-un text dat caracterele x și y citite de la tastatură.
            */

            //Citirea datelor de la tastatura 
            Console.WriteLine("Introduceti textul:");
            string s = Console.ReadLine();
            Console.WriteLine("Caracterul cautat x:");
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine("Caracterul cautat y:");
            char y = char.Parse(Console.ReadLine());

            //Algoritmul de rezolvare
            int nrx = 0;
            int nry = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == x)
                {
                    nrx++;
                }
                if (s[i] == y)
                {
                    nry++;
                }
            }


            //Afisarea rezultatului
            Console.WriteLine("In textul: \n {0}", s);
            Console.WriteLine("Caracterul {0} este intalnit de {1} ori", x, nrx);
            Console.WriteLine("Caracterul {0} este intalnit de {1} ori", y , nry);
            Console.ReadKey();
        }
    }
}
