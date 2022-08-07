using System;

namespace ff
{
    class Program
    {
        //static int n , m;
        //static int[,] mas;


        static int Main()
        {
            //CitireMasiv();
            //CitieValori();
            //AfisareMasiv();
            //AfisareMax();
            //AfisareMin();
            //AfisareProd();

            int i = 10;
            int j = 10;
            Console.WriteLine(i+" "+j);
            show(i,out j);
            Console.WriteLine(i + " " + j);
            return 0;
        }

        private static void show(int i,out int j)
        {
            j = 15;
            for (int z = 0; z < 10; z++)
            {
                i++;
                j++;
            }
            Console.WriteLine(i + " " + j);
        }

        //private static void AfisareProd()
        //{
        //    Console.WriteLine($"Produsul este: {Produsul()}" );
        //}

        //private static int Produsul()
        //{
        //    int produs = 1;
        //    foreach (int item in mas)
        //    {
        //        produs *= item;
        //    }
        //    return produs;
        //}

        //private static void AfisareMin()
        //{
        //    Console.WriteLine($"Elementul minim: {Min()}");
        //}

        //private static int Min()
        //{
        //    int min = int.MaxValue;
        //    foreach (var item in mas)
        //    {
        //        min = (item < min) ? item:min;
        //    }
        //    return min;
        //}

        //private static void AfisareMax()
        //{
        //    Console.WriteLine($"Elementul maxim: {Max()}");
        //}

        //private static int Max()
        //{
        //    int max = int.MinValue;
        //    foreach (var item in mas)
        //    {
        //        max = (item > max) ? item : max;
        //    }
        //    return max;
        //}

        //private static void AfisareMasiv()
        //{
        //    Console.Clear();
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.Write(mas[i, j]+" "); 
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //private static void CitieValori()
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            mas[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }
        //}

        //private static void CitireMasiv()
        //{
        //    Console.Write("n = ");
        //    n = int.Parse(Console.ReadLine());
        //    Console.Write("m = ");
        //    m = int.Parse(Console.ReadLine());
        //    mas = new int[n, m];
        //}
    }
}
