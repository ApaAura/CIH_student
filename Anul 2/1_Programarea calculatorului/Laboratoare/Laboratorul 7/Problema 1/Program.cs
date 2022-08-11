using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problema_1
{
    /*
     Sa se creeze o lista legata elementele careia reprezinta siruri de caractere. Sa se numere elementele ce 
     se incep cu o vocala. Sa se determie timpul de executie al algoritmului si necesarul de memorie.
     */
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> listaElementelor = new LinkedList<string>();
            string element;
            char prelungire = 'D';
            do
            {
                Console.Write("Introdu elementul listei: ");
                element = Console.ReadLine();
                listaElementelor.AddLast(element);
                Console.Write("Mai introduceti elemente? : D/N ");
                prelungire = char.Parse(Console.ReadLine());
            } while (prelungire == 'D');
            Console.Clear();
            Console.WriteLine("\nLista initiala: ");
            TiparesteLista(listaElementelor);
            Stopwatch stw = new Stopwatch();
            stw.Start();
            string sir;
            int nrVocale = 0;
            List<char> vocale = new List<char> {'a', 'e', 'i', 'o', 'u'};
            foreach (string el in listaElementelor)
            {
                sir = el.ToLowerInvariant();
                if (vocale.Contains(sir[0]))
                {
                    nrVocale++;
                }
            }
            long memorieProc = Process.GetCurrentProcess().WorkingSet64;
            Console.WriteLine($"\nElementele ce incep cu o vocala sunt {nrVocale} :");
            Console.WriteLine("-------------------------------------------------------");
            stw.Stop();
            TimeSpan ts = stw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"Timpul de executie este: {elapsedTime}");
            Console.WriteLine($"Memoria alocata este: {memorieProc/1000} Kbyte");
            Console.ReadKey();
        }
        static void TiparesteLista(LinkedList<string> lista)
        {
            foreach (string el in lista)
            {
                Console.Write(el+" ");
            }
        }
    }
}
