using System;

namespace Problema_4
{
    class Program
    {
        static int Invers(int t)
        {
            int b = 0;
            while (t != 0)
            {
                b = b * 10 + t % 10;
                t = t / 10;
            }
            return b;
        }
        static void Main(string[] args)
        {/* De la tastatură se citeşte un număr întreg n, n<100000.
            Elaborați un program cu funcții prin intermediul căruia se va determina: răsturnatul numărului.*/
            Console.WriteLine("Introduceti un numar");
            int nr;
            for (; ; )
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > 100000) Console.WriteLine("Numar invalid\nIntroduceti un numar"); else break;
            }
            Console.Write(Invers(nr));
            Console.ReadKey();
        }
    }
}
