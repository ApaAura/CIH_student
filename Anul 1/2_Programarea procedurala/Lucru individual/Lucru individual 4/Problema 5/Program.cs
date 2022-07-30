using System;
using System.IO;

namespace Problema_5
{
    class Program
    {
        static public int n;
        static void Main(string[] args)
        {
            // Dintr - un fișier date.in se citește un număr întreg n. Să se determine factorialul acestui 
            // număr folosind o funcție iterativă ce primește ca parametru acest număr, rezultatul să fie afișat la ecran.
            using (StreamReader rd = new StreamReader("date.in"))
            {
                n = int.Parse(rd.ReadLine());
            }
            Console.WriteLine($"{n}! = {Factorial(n)}");
        }
        private static object Factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                double fact = 1;
                for (int i = 0; i <= n; i++)
                {
                    fact *= n;
                }
                return fact;
            }
        }
    }
}
