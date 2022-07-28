using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problema 3:
            Se citește numărul natural impar n, şi două caractere c şi d. 
            Să se afișeze următorul pătrat, format din n linii şi n coloane, în care cele două caractere alternează:

            cdc...dc
            dcd...cd
            ....
            dcd...cd
            cdc...dc
            */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti caracterul 1 : ");
            char ch1 = char.Parse(Console.ReadLine());
            Console.Write("Introduceti caracterul 2 : ");
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    for (int f = 0; f < n / 2; f++)
                    {
                        Console.Write($"{ch1} {ch2} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int f = 0; f < n / 2; f++)
                    {
                        Console.Write($"{ch2} {ch1} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
