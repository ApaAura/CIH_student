using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemte :" );
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("masiv[{0}]= ", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cel mai mare element prim din masiv : {0}", DivideEtImpera(masiv, 0, n - 1));
            Console.ReadKey();
        }
        static int Prim(int numar)
        {
            int contor = 0;
            for (int i = 1; i <= numar; i++)
            {
                if (numar % i == 0)
                {
                    contor++;
                }
            }
            if (contor == 2)
            {
                return numar;
            }
            else
                return 0;
        }
        static int DivideEtImpera(int[] v, int i, int j)
        {
            int a, b;
            if (i == j)
            {
                return v[i];
            }
            else
            {
                a = DivideEtImpera(v, i, (i + j) / 2);
                b = DivideEtImpera(v, (i + j) / 2 + 1, j);
                if (Prim(a) > Prim(b))
                {
                    return a;
                }
                else return b;
            }
        }
    }
}
