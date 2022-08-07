using System;

namespace Program1
{
    class Program
    {
        public static int c = 0;
        public static int r = 0;
        public static int[,] tabel;
        static void Main(string[] args)
        {
            Citire();
            Console.WriteLine("Introduceti elementele tabelului: ");
            tabel = Verde();
            Afisare();
            int elMax = Max(tabel);
            Console.WriteLine($"\nElementul maxim este:  {elMax}");
            Min();
            int suma = Suma();
            Console.WriteLine($"Suma este:  {suma}");
            Diferenta();
            Console.ReadKey();
        }

        private static void Afisare()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{tabel[i,j]}  ");
                }
                Console.WriteLine();
            }
        }

        private static void Diferenta()
        {
            int dif = 0;
            for (int i = 0; i < r; i++)
            {
                dif-=tabel[i, i];
            }
            Console.WriteLine($"Diferenta este: {dif}");
        }

        private static int Suma()
        {
            int sum = 0;
            foreach (var item in tabel)
            {
                sum += item;
            }
            return sum;
        }

        private static void Min()
        {
            int min = int.MaxValue;
            foreach (var item in tabel)
            {
                if (item<min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Elementul minim este:  {min}");
        }
        private static int Max(int[,] strada)
        {
            int max = int.MinValue;
            foreach (var item in strada)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        private static int[,] Verde()
        {
            int[,] gard = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    gard[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return gard;
        }

        private static void Citire()
        {
            Console.Write("Introduceti numarul de randuri: ");
            r = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane: ");
            c = int.Parse(Console.ReadLine());
        }
    }
}
