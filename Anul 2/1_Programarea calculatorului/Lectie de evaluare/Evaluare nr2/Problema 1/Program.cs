using System;

namespace Problema_1
{
    class Program
    {
        //Subgrupa 1: Se dă un şir cu n elemente, numere naturale. Folosind metoda Divide et Impera să 
        //se verifice dacă în şir există elemente impare
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                masiv[i] = el.Next(0, 100);
            }
            Console.Clear();
            Console.WriteLine("Elementele masivului: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(masiv[i] +" ");
            }
            if (DivideEtImpera(masiv, 0, n-1)==0)
            {
                Console.WriteLine("\nNu sunt elemente impare !");
            }
            else
            {
                Console.WriteLine($"\nElementele impare: {DivideEtImpera(masiv, 0, n-1)}");
            }
            Console.ReadKey();
        }
        private static int DivideEtImpera(int[] masiv, int left, int right)
        {
            int a, b;
            if (left==right)
            {
                if (masiv[left] % 2 != 0)
                    return 1;
                else
                    return 0;
            }
            else
            {
                a = DivideEtImpera(masiv, left, (left + right) / 2);
                b = DivideEtImpera(masiv, (left + right) / 2 + 1, right);
                return a + b;
            }
        }
    }
}
