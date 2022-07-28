using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 1: 
             Se da numărul natural n. 
             Să se afle media aritmetică a unui șir de n numere date.
             */

            int[] a;
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            int sum = 0;
            Console.WriteLine($"Introduceti {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}:");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine($"Med: {sum/n:F2}");
            Console.ReadKey();
        }
    }
}
