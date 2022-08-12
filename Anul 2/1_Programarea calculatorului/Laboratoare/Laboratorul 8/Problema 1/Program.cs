using System;
using System.IO;
using System.Diagnostics;

namespace Problema_1
{
    /*
     Se citeste un numar natural n. Afisati permutarile multimii 1,2,3...n in care
     pana la jumatate elementele sunt in ordine descrescatoare, iar de la jumatate 
     pana la final in ordine descrescatoare.
     */
    class Program
    {
        public static int nr;
        public static int[] sol = new int[20];
        public static int[] p = new int[20];

        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Stopwatch stw = new Stopwatch();
                    stw.Start();
                    using (StreamWriter wr = new StreamWriter("date.out"))
                    {
                        wr.WriteLine("Permutarile obtinute: ");
                    }
                    Console.WriteLine("Pemutarile obtinute: ");
                    Citire();
                    Triere(1);
                    long memorieProc = Process.GetCurrentProcess().WorkingSet64;
                    stw.Stop();
                    TimeSpan ts = stw.Elapsed;
                    Console.WriteLine("Datele au fost inscrise cu succes !");
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    Console.WriteLine($"\nTimpul de executie este: {elapsedTime}");
                    Console.WriteLine($"Memoria alocata este: {memorieProc / 1000} Kbyte");
                    isValid = true;
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare !");
                    isValid = false;
                }
            }
        }
        private static void Citire()
        {
            using (StreamReader rd=new StreamReader("date.in"))
            {
                nr = int.Parse(rd.ReadLine());
            }
        }
        private static void Triere(int m)
        {
            for (int i = 0; i <= m; i++)
            {
                if (p[i]==0)
                {
                    sol[m] = i;
                    p[i] = 1;
                    if (Valid(m))
                    {
                        if (m==nr)
                        {
                            Afisare();
                        }
                        else
                        {
                            Triere(m + 1);
                        }
                        p[i] = 0;
                    }
                }
            }
        }
        private static void Afisare()
        {
            using (StreamWriter wr=new StreamWriter("date.out", append:true))
            {
                for (int i = 1; i <= nr; i++)
                {
                    wr.Write($"{sol[i]} ");
                    Console.Write($"{sol[i]}");
                }
                wr.WriteLine();
                Console.WriteLine();
            }
        }
        private static bool Valid(int o)
        {
            if (o>1)
            {
                if (o<=(nr+1)/2)
                {
                    if (sol[o]<sol[o-1])
                    {
                        return false;
                    }
                }
                else
                {
                    if(sol[o]<sol[o-1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
