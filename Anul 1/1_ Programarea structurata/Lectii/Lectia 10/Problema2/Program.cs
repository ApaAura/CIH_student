using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problema 2.
            Se citește numărul natural n, şi două caractere c şi d.
            Să se afișeze următorul pătrat, format din n linii şi n coloane:

             ccc...cc
             cdd...dc
             ....
             cdd...dc
             ccc...cc
            */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti caracterul 1 : ");
            char ch1 = char.Parse(Console.ReadLine());
            Console.Write("Introduceti caracterul 2 : ");
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{ch1} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write($"{ch1} ");
                for (int f = 0; f < n - 2; f++)
                {
                    Console.Write($"{ch2} ");
                }
                Console.WriteLine($"{ch1} ");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{ch1} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
