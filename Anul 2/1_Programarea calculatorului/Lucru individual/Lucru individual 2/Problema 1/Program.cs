using System;

namespace Problema_1
{
    class Program
    {
        /*
         Se considera numerele naturale din multimea 0,1,2,…,n}.Elaborati un
         program care determina cate numere prime sunt mai mari decat
         numarul natural dat m folosind metoda Trierii
         */
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar natural: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti parametrul m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Solutia:");
            for (int i = n; i <= m; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
