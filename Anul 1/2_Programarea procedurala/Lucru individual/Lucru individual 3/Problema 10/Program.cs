using System;
using System.IO;

namespace Problema_10
{
    class Program
    {
        static int MicDiv(int m, int t)
        {
            int r;
            if (m == t) return 1; else return MicDiv(m % t, m);
        }
        static void Main(string[] args)
        {/* Dintr-un fișier cu numele ”DATE.IN” se citesc două numere întregi x și n.
            De elaborat o funcție recursivă ce primește ca parametri aceste două numere și calculează cel mai mic divizor comun al acestor numere. 
            Rezultatul să fie afișat la ecran.*/

            StreamReader Fish = new StreamReader("date.in");
            string[] t = new string[2];
            t = Fish.ReadLine().Split(' ');
            Fish.Close();
            int nr1 = int.Parse(t[0]);
            int nr2 = int.Parse(t[1]);
            Console.Write(MicDiv(nr1, nr2));
            Console.ReadKey();
        }
    }
}
