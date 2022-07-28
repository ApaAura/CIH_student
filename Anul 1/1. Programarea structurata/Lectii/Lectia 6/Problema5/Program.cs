using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            if (b!= 0)
            {
                Double B = (a / b);
                Console.WriteLine($"{a}/{b}={B}");
            }
            else
            {
                Console.WriteLine($"Împărţire imposibilă");
            }
            Console.ReadKey();

        }
    }
}
