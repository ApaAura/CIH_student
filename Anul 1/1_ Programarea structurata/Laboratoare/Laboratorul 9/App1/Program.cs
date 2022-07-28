using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numere intregi");
            Console.WriteLine("For method");
            int pare = 0;
            int nr = int.Parse(Console.ReadLine());
            for (; nr!=0 ;)
            {
                if (nr%2==0)
                {
                    pare++;
                }
                nr = int.Parse(Console.ReadLine());
            }
            if (pare == 0)
            {
                Console.WriteLine("nu exista");
            }
            else
            {
                Console.WriteLine($"Numere pare {pare}");
            }
            Console.WriteLine("while method");
            pare = 0;
            nr = 1;
            while(nr != 0)
            {
                if (nr % 2 == 0)
                {
                    pare++;
                }
                nr = int.Parse(Console.ReadLine());
            }
            if (pare == 0)
            {
                Console.WriteLine("nu exista");
            }
            else
            {
                Console.WriteLine($"Numere pare {pare}");
            }
            Console.WriteLine("Do while method");
            pare = 0;
            nr = 1;
            do
            {
                nr = int.Parse(Console.ReadLine());
                if (nr ==0)
                {
                    break;
                }
                if (nr%2==0)
                {
                    pare++;
                }
            } while (nr!=0);
            if (pare == 0)
            {
                Console.WriteLine("nu exista");
            }
            else
            {
                Console.WriteLine($"Numere pare {pare}");
            }
        }
    }
}
