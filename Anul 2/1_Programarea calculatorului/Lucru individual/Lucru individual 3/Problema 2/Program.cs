using System;
using System.IO;

namespace Problema_2
{
    class Program
    {
        static int n, m1, m2;
        static int x,y;
        static int[,] A = new int[101, 101];
        static int[,] B = new int[101, 101];

        static void Main(string[] args)
        {
            /*
             Se dau două grafuri neorientate G1 și G2 cu n (n<=100) vârfuri și m1, respectiv m2 muchii prin listele muchiilor,
             în două fișiere graf1.in, respectiv graf2.in. Verificați dacă unul dintre ele este graf parțial al celuilalt. 
             Se va preciza dacă G1 este graf parțial al lui G2, dacă G2 este graf parțial al lui G1 sau NU dacă niciunul dintre 
             ele este graf parțial al celuilalt.
                Exemplu:
                    graf1.in
                    5 2
                    1 4
                    1 3
                    graf2.in
                    5 5
                    1 4
                    1 3
                    3 5
                    4 5
                    2 5
                    graf.out
                    G1 este graf partial al lui G2
             */
            StreamReader rd = new StreamReader("graf1.in");
            string[] ln = rd.ReadLine().Split(' ');
            n = int.Parse(ln[0]);
            m1 = int.Parse(ln[1]);
            for (int i = 0; i < m1; i++)
            {
                ln = rd.ReadLine().Split(' ');
                A[int.Parse(ln[0]), int.Parse(ln[1])] = 1;
            }
            rd.Close();
            rd = new StreamReader("graf2.in");
            ln = rd.ReadLine().Split(' ');
            n = int.Parse(ln[0]);
            m2 = int.Parse(ln[1]);
            for (int i = 0; i < m2; i++)
            {
                ln = rd.ReadLine().Split(' ');
                B[int.Parse(ln[0]), int.Parse(ln[1])] = 1;
            }
            using (StreamWriter er = new StreamWriter("graf.out"))
                if (m1 > m2)
                    if (graf_partial(n, A, B))
                    {
                        Console.WriteLine("G2 este graf partial al lui G1");
                        er.WriteLine("G2 este graf partial al lui G1");
                    }
                    else
                    {
                        Console.WriteLine("NU");
                        er.WriteLine("NU");
                    }
                else
                    if (graf_partial(n, B, A))
                    {
                        Console.WriteLine("G1 este graf partial al lui G2");
                        er.WriteLine("G1 este graf partial al lui G2");
                    }
                    else
                    {
                        Console.WriteLine("NU");
                        er.WriteLine("NU");
                    }
        }
        private static bool graf_partial(int n, int[,] a, int[,] b)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (B[i,j] == 1 && A[i,j] == 0) return false;
            return true;
        }
    }
}
