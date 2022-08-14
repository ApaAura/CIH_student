using System;

namespace Problema_2
{
    class Program
    {
        //Folosind metoda Devide Et Impera calculati suma elementelor unui vector
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = el.Next(0,100);
            }
            Console.WriteLine("Elementele masivului: ");
            foreach (int i in vector)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine($"\nSuma elementelor vectorului: {SumaDivide(vector,0, n-1)}");
        }
        private static int SumaDivide(int[] vector, int left, int right)
        {
            if (left==right)
            {
                return vector[left];
            }
            else
            {
                return SumaDivide(vector, left, (left + right) / 2) + SumaDivide(vector, (left + right) / 2 + 1, right);
            }
        }
    }
}
