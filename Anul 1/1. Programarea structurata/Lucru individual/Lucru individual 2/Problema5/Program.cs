using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 5:Scrieți un program care să afișeze, în ordine crescătoare,
             toate numerele naturale formate din câte n cifre și care au suma cifrelor 
             egală cu s, precum și câte astfel de numere există. Exemplu: Pentru valorile citite: 
             n=2 și s=5 se vor afișa numerele 14, 23, 32, 41, 50; în total sunt 5 numere
             */
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti s: ");
            int s = int.Parse(Console.ReadLine());
            int maxVal = s;
            int minVal = 1;
            for (int i = 1; i < n; i++)
            {
                maxVal *= 10;
                minVal *= 10;
            }
            int actual = 0;
            int sum = 0;
            int count = 0;
            for (int i = minVal; i <= maxVal; i++)
            {
                actual = i;
                while (actual != 0)
                {
                    sum += actual % 10;
                    actual /= 10;
                }
                if (sum==s)
                {
                    count++;
                    Console.Write(i+" ");
                }
                sum = 0;
            }
            Console.WriteLine($"\nAu fost gasite {count} numere care indeplinesc conditia");
            Console.ReadKey();
        }
    }
}
