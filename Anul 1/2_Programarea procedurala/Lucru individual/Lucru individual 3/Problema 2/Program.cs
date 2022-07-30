using System;

namespace Problema_2
{
    class Program
    {
       static int NrCifPar(int t)
        {
            int nrCifPar = 0;
            int loc=0;
            while (t != 0)
            {
                loc =t % 10;
                t /= 10;
                if (loc%2==0) nrCifPar++;
            }
            return nrCifPar;
        }
        static void Main(string[] args)
        {/* De la tastatură se citeşte un număr întreg n, n<100000. 
            Elaborați un program cu funcții prin intermediul căruia se va determina: numărul de cifre pare.*/

            Console.WriteLine("Introduceti un numar");
            int nr;
            for (; ; )
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > 100000) Console.WriteLine("Numar invalid\nIntroduceti un numar"); else break;
            }
            Console.Write("Numarul {0} contine {1} cifre pare", nr, NrCifPar(nr));
            Console.ReadKey();
        }
    }
}
