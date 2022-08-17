using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string go = "";
            do
            {
                Console.Clear();
                Console.Write("Numarul de elemente ale masivului: n = ");
                int n = int.Parse(Console.ReadLine());
                int[] masiv = new int[n];
                Random el = new Random();
                for (int i = 0; i < n; i++)
                {
                    masiv[i] = el.Next(1, 100);
                }
                Array.Sort(masiv);
                AfisareMasiv(masiv);
                Console.Write("\nValoarea cautata key= ");
                int key = int.Parse(Console.ReadLine());
                int rezultat = BinarySerach(masiv, key);
                if (rezultat ==-1)
                {
                    AfisareMasiv(masiv);
                    Console.WriteLine($"\nElementul {key} lipseste !");
                }
                else
                {
                    AfisareMasiv(masiv);
                    Console.WriteLine($"\nElementul {key} se afla pe pozitia {rezultat}");
                }
                Console.Write("Pentru iesire tastati 'quit'");
                go = Console.ReadLine();
            } while (go != "quit");
            Console.ReadKey();
        }
        private static int BinarySerach(int[] masiv, int key)
        {
            //metoda iterativa
            int left, right, middle;
            left = 0;
            right = masiv.Length - 1;
            while (left<=right)
            {
                middle = (left + right) / 2;
                if (key<masiv[middle])
                {
                    right = middle + 1;
                }
                else
                {
                    if (key>masiv[middle])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        return middle;
                    }
                }
            }
            //metoda recursiva
            //if (left >= right)
            //{
            //     int middle = left + (right - left) / 2;
            //    if (masiv[middle] == key) return middle;
            //    if (masiv[middle] > key) return BinarySerach(masiv, left, middle - 1, key);
            //    return BinarySerach(masiv, middle + 1, right, key);
            //}
            return -1;
        }
        private static void AfisareMasiv(int[] masiv)
        {
            Console.WriteLine("Masivul initial: ");
            foreach (var item in masiv)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
