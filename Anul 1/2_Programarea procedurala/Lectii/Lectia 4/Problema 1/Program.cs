using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coadaNumere = new Queue<int>();
            bool go = true;
            do
            {
                int userChoose = ShowMenu();
                switch (userChoose)
                {
                    case 1:
                        Console.WriteLine("Introdu datele:\n");
                        coadaNumere = IntroduDatele(coadaNumere);
                        break;
                    case 2:
                        Console.WriteLine("Afiseaza coada:");
                        AfisareCoada(coadaNumere);
                        break;
                    case 3:
                        Console.WriteLine("Sterge datele:\n");
                        coadaNumere = StergeNumere(coadaNumere);
                        break;
                    case 0:
                        go = false;
                        Console.WriteLine("Iesire");
                        break;
                    default:
                        Console.WriteLine("Nu exista astfel de optiune!");
                        break;
                }
            } while (go);
        }

        private static Queue<int> StergeNumere(Queue<int> coadaNumere)
        {
            if (coadaNumere.Count !=0)
            {
                while (coadaNumere.Count>0)
                {
                    if (!Prim(coadaNumere.Peek()))
                    {
                        coadaNumere.Dequeue();
                    }
                    else break;
                }
                Console.Clear();
                Console.WriteLine("Datele au fost sterse!");
            }
            else
            {
                Console.WriteLine("Coada este pustie!");
            }
            return coadaNumere;
        }
        private static bool Prim(int numar)
        {
            int prim = 1;
            int d = 2;
            while (d<=numar/2)
            {
                if (numar%d==0)
                {
                    prim = 0;
                }
                d++;
            }
            if (prim == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private static void AfisareCoada(Queue<int> coadaNumere)
        {
            if (coadaNumere.Count !=0)
            {
                Console.WriteLine("Coada numerelor: \n");
                foreach (int numar in coadaNumere)
                {
                    Console.Write(numar+" ");
                }
            }
            else
            {
                Console.WriteLine("Coada este pustie!");
            }
        }
        private static Queue<int> IntroduDatele(Queue<int> coadaNumere)
        {
            Console.Clear();
            Console.Write("Numarul de elemente in coada n = ");
            int n = int.Parse(Console.ReadLine());
            Random numar = new Random();
            for (int i = 0; i < n; i++)
            {
                coadaNumere.Enqueue(numar.Next(1, 100));
            }
            return coadaNumere;
        }
        private static int ShowMenu()
        {
            int userChoose_int = 0;
            bool ok;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Introdu datele: ");
                Console.WriteLine("2. Afiseaza datele: ");
                Console.WriteLine("3. Sterge datele: ");
                Console.WriteLine("0. Iesire");
                string userChoose = Console.ReadLine();
                ok = int.TryParse(userChoose, out userChoose_int);
                if (!ok)
                {
                    Console.WriteLine("Nu exista astfel de optiune!");
                }
            } while (!ok);
            return userChoose_int;
        }
    }
}
