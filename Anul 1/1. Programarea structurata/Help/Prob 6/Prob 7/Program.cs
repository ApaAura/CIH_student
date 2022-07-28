using System;

namespace Prob_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //De la tastatură este citit un număr natural n.Să se determine şi să se afişeze factorialul acestui număr
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            double Factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Factorial *= i;
            }
            Console.WriteLine("{0}!={1}",n,Factorial);
        }
    }
}
