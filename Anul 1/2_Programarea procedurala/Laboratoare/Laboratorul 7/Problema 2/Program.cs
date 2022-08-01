using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problema_2
{
    class Program
    {
        /*
         Sa se creeze o lista legata cu elementele reale. Sa se elimine din aceasta lista elementele negative.
         Sa se afiseze aceasta lista modificata si timpul de executie a algoritmului si necesarul de memorie.
         */
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente ale listei: ");
            int nr = int.Parse(Console.ReadLine());
            List<float> lista = new List<float>();
            Console.WriteLine("Introduceti elementele listei: ");
            for (int i = 0; i < nr; i++)
            {
                int el = int.Parse(Console.ReadLine());
                lista.Add(el);
            }
            Console.Clear();
            Console.WriteLine("Elememtele listei: ");
            foreach (float el in lista)
            {
                Console.Write(el+" ");
            }
            Stopwatch stw = new Stopwatch();
            stw.Start();
            List<float> elNegative = new List<float>();
            foreach (float el in lista)
            {
                if (el<0)
                {
                    elNegative.Add(el);
                }
            }
            long memorieProc = Process.GetCurrentProcess().WorkingSet64;
            Console.WriteLine($"\nElementele negative: ");
            foreach (float el in elNegative)
            {
                Console.Write(el+" ");
            }
            stw.Stop();
            TimeSpan ts = stw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"\nTimpul de executie este: {elapsedTime}");
            Console.WriteLine($"Memoria alocata este: {memorieProc / 1000} Kbyte");
            Console.ReadKey();
        }
    }
}
