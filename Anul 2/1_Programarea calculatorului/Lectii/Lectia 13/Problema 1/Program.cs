using System;
using System.IO;

namespace Problema_1
{
    class Program
    {
        static StreamReader fin = new StreamReader("input.txt");
        static StreamWriter fout = new StreamWriter("output.txt");
        static int n;
        static int[,] map;
        static int ndr = 0;
        static void Main(string[] args)
        {
            string linie;
            string[] elemlinie;
            try
            {
                using (fin)
                {
                    linie = fin.ReadLine();
                    n = int.Parse(linie);
                    map = new int[n + 1, n + 1];
                    for (int i = 1; i <= n; i++)
                    {
                        linie = fin.ReadLine();
                        elemlinie = linie.Split(' ');
                        for (int j = 0; j <= n; j++)
                        {
                            map[i, j] = int.Parse(elemlinie[j - 1]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Eroare la deschiderea fisierului !");
            }
            try
            {
                using (fout)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (map[i,j]==1)
                            {
                                ndr++;
                            }
                        }
                    }
                    fout.Write(ndr);
                    Console.WriteLine(ndr);
                    Console.WriteLine("Datele au fost inscrise cu succes !");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Eroare la scrierea fisierului !");
            }
        }
    }
}
