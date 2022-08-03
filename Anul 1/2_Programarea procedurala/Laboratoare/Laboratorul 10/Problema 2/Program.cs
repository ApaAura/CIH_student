using System;

namespace Problema_2
{
    /*
     Se citesc doua numere naturale n si s (n<=10, s<=20). Afisati în ordine crescătoare toate numerele cu n cifre
     care au suma cifrelor egala cu s si în care oricare doua cifre alăturate au paritate diferită.
     Exemple: n=4, s=8 => 1016, 1034, 1052, 1070, 1214, 1232, 7010
     */
    class Program
    {
        static int n = 0;
        static int s = 0;
        static int[] masiv = new int[11];

        static void Main(string[] args)
        {
            Console.Write("N =  ");
            n = int.Parse(Console.ReadLine());
            Console.Write("S =  ");
            s = int.Parse(Console.ReadLine());
            Back(1, 0);
            Console.ReadKey();
        }
        private static void Back(int k, int sp)
        {
            for (int i = 0; i <= 9; i++)
            {
                masiv[k] = i;
                sp = sp + masiv[k];
                if (masiv[1]!=0 && (k==1|| masiv[k]%2!=masiv[k-1]%2) && sp<=s)
                {
                    if (k==n)
                    {
                        if (sp==s)
                        {
                            Afisare();
                        }
                    }
                    else
                    {
                        Back(k + 1, sp);
                    }
                }
                sp = sp - masiv[k];
            }
        }
        private static void Afisare()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{masiv[i]}");
            }
            Console.WriteLine();
        }
    }
}
