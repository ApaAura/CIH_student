using System;

namespace Problema_1
{
    class Program
    {
        static int NrCif(int t)
        {
            int nrCif = 0;
            while (t != 0)
            {
                t /= 10;
                nrCif++;
            }
            return nrCif;
        }
        static void Main(string[] args)
        {/* De la tastatură se citeşte un număr întreg n, n<100000. 
            Elaboraţi un program cu funcţii prin intermediul căruia se va determina: numărul de cifre din scrierea acestui număr.*/

            Console.WriteLine("Introduceti un numar");
            int nr;
            for (; ; )
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > 100000) Console.WriteLine("Numar invalid\nIntroduceti un numar"); else break;
            }
            Console.Write("Numarul {0} contine {1} cifre", nr, NrCif(nr));
            Console.ReadKey();

        }
    }
}
