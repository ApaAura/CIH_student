using System;
using System.IO;

namespace Problema_6
{
    class Program
    {
        static public int n;
        static void Main(string[] args)
        {
            // Dintr-un fișier date.in se citește un număr întreg n. Să se determine factorialul acestui 
            // număr folosind o funcție recursivă ce primește ca parametru acest număr, rezultatul să fie afișat la ecran.
            using (StreamReader rd=new StreamReader("date.in"))
            {
                n = int.Parse(rd.ReadLine());
            }
            Console.WriteLine($"{n}! = {Factorial(n)}");
        }
        private static int Factorial(int n)
        {
            if (n==0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
