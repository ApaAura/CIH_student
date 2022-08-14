using System;
using System.IO;

namespace Problema_1
{
    class Program
    {

        /*
         Într-o subterană sunt M tunelrui și N intersecții, fiecare tunel unește careva două intersecții. 
         S-a hotărît să fie instalate semafoare înaintea fiecărei intersecții. 
         Elaborați o aplicație, care va calcula, cîte semafoare trebuie de instalat înaintea 
         fiecărei intersecții. Intersecțiile sunt numerotate de la 1 la N. 
         Date de intrare: Fișierul INPUT.TXT pe prima linie se conțin numerele 
         N și M (0 < N ≤ 100, 0 ≤ M ≤ N*(N-1)/2). Pe următoare M linii sunt scrie câte două numere i și j (1 ≤ i,j ≤ N), 
         care reprezintă că intersecția i și j este unită cu un tunel. Nu există tunel doar de la intersecția i pînă la sine însăși.
         Fișierul de ișire OUTPUT.TXT va conține N numere: fiecare k număr va reprezenta cantitatea de semafoare la intersecția k.
         */

        private static int[,] MA;
        private static int N, M;
        private static int[] rezultat;
        static void Main(string[] args)
        {
            Citire();
            Calculare();
            Afisare();
        }
        private static void Citire()
        {
            if (File.Exists("INPUT.TXT"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader("INPUT.TXT"))
                    {
                        string[] linie = sr.ReadLine().Split(' ');
                        N = int.Parse(linie[0]);
                        M = int.Parse(linie[1]);
                        MA = new int[N + 1, N + 1];
                        rezultat = new int[N + 1];
                        for (int i = 0; i < M; i++)
                        {
                            linie = sr.ReadLine().Split(' ');
                            int i1 = int.Parse(linie[0]);
                            int j1 = int.Parse(linie[1]);
                            MA[i1, j1] = MA[j1, i1] = 1;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare la citirea datelor. ");
                }
            }
            else
            {
                Console.WriteLine("Eroare. Nu exista fisierul INPUT.TXT");
            }
        }
        private static void Calculare()
        {
            int sum;
            for (int i = 1; i <= N; i++)
            {
                sum = 0;
                for (int j = 1; j <= N; j++)
                {
                    sum += MA[i, j];
                }
                rezultat[i] = sum;
            }
        }
        private static void Afisare()
        {
            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                for (int i = 1; i <= N; i++)
                {
                    sw.Write(rezultat[i] + " ");
                }
            }
        }
    }
}
