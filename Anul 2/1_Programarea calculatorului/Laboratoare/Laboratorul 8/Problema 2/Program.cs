using System;
using System.IO;
using System.Diagnostics;

namespace Problema_2
{
    /*
     Sa se afiseze in ordine alfabetica anagramele unui
     cuvant format din literele distinte.
     */
    class Program
    {
        public static int nr;
        public static char[] v = new char[100];
        public static int[] st = new int[50];
        public static int[] p = new int[50];
        static void Main(string[] args)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            Citeste();
            nr= v.Length;
            Ordonez(v, nr);
            Back(1);
            long memorieProc = Process.GetCurrentProcess().WorkingSet64;
            stw.Stop();
            TimeSpan ts = stw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"\nTimpul de executie este: {elapsedTime}");
            Console.WriteLine($"Memoria alocata este: {memorieProc / 1000} Kbyte");
        }
        private static void Back(int k)
        {
            for (int i = 1; i <= nr; i++)
            {
                if (p[i] != 1)
                {
                    st[k] = i;
                    p[i] = 1;
                    if (k == nr) 
                    {
                        Scrie();
                    }
                    else
                    {
                        Back(k + 1);
                    }
                    p[i] = 0;
                }
            }
        }
        private static void Scrie()
        {
            using (StreamWriter wr=new StreamWriter("date.out"))
            {
                for (int i = 1; i <= nr; i++)
                {
                    wr.Write($"{v[st[i]-1]}");
                    Console.Write($"{v[st[i] - 1]}");
                }
                wr.WriteLine();
                Console.WriteLine();
            }
        }
        private static void Ordonez(char[] v, int n)
        {
            for (int i = 0; i < nr; i++)
            {
                for (int j = i+1; j < nr; j++)
                {
                    if (v[i]>v[j])
                    {
                        char aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
        private static void Citeste()
        {
            using (StreamReader rd=new StreamReader("date.in"))
            {
                v = rd.ReadLine().ToCharArray();
            }
        }
    }
}
