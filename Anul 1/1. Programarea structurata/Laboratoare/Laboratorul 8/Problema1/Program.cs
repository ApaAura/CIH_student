using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             De la tastatură se citesc n numere întregi pozitive. Elaborați un
             program care va determina suma şi media numerelor citite cu excepţia
             numerelor unde suma cifrelor este un număr impar.
            */

            int[] a;
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            Console.WriteLine($"Introduceti {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i+1}:");
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0; //Suma cifrelor
            int nr = 0; //Numarul citit
            int sm = 0; //Suma numerelor cu suma para a cifrelor 
            int count = 0; //contorul , cate numere cu suma para a cifrelor s-a gasit
            for (int i = 0; i < n; i++)
            {
                nr = a[i];
                sum = 0;
                //Suma cifrelor numarului
                for (; ; )
                {
                    sum += nr % 10;
                    nr /= 10;
                    if (nr == 0)
                    {
                        break;
                    }
                }
                //Verificare paritatea sumei cifrelor
                if (sum % 2 == 0)
                {
                    count++;
                    sm += a[i];
                }
            }
            Console.WriteLine($"Suma elementelor cu suma cifrelor para: {sm}\n" +
                $"Media aritmetica a elementelor cu suma cifrelor para: {sm/count}");
            Console.ReadKey();
        }

    }
}
