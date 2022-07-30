using System;
using System.IO;
namespace Problema_11
{
    class Program
    {
        static void Med(int m, int n)
        {
            float med = (float)(m + n) / 2;
            Console.WriteLine("Media aritmetica:{0:f2}", med);
        }
        static void Main(string[] args)
        {/*	Dintr-un fișier cu numele ”DATE.IN” se citesc două numere întregi x și n. 
            De elaborat o procedură ce primește ca parametri aceste două numere și calculează media aritmetică a lor. 
            Rezultatul să fie afișat la ecran.*/

            StreamReader Fish = new StreamReader("date.in");
            string[] t = new string[2];
            t = Fish.ReadLine().Split(' ');
            Fish.Close();
            int x = int.Parse(t[0]);
            int n = int.Parse(t[1]);
            Med(x, n);
            Console.ReadKey();
        }
    }
}
