using System;
using System.IO;

namespace Problema_9
{
    class Program
    {
        static int Putere(int m, int t)
        {
            if (t == 1) return m; else return m * Putere(m, t - 1);
        }
        static void Main(string[] args)
        {/*	Dintr-un fișier cu numele ”DATE.IN” se citesc două numere întregi x și n.
            De elaborat o funcție recursivă ce primește ca parametri aceste două numere și calculează puterea lor: x^n. Rezultatul să fie afișat la ecran.*/

            StreamReader Fish = new StreamReader("date.in");
            string[] t = new string[2];
            t = Fish.ReadLine().Split(' ');
            Fish.Close();
            int nr1 = int.Parse(t[0]);
            int nr2 = int.Parse(t[1]);
            Console.WriteLine("{0}^{1}={2}", nr1, nr2, Putere(nr1, nr2));
            Console.ReadKey();
        }
    }
}
