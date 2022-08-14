using System;
using System.Linq;

namespace Problema_2
{
    class Program
    {
        /*
         Se considera ca dispunem de un rucsac cu capacitatea M si de N obiecte,
         definite fiecare prin greutate si valoare, ce trebuie introduce in rucsac. Se
         cere o modalitate de a umple rucsacul cu obiecte , astfel incat valoarea totala
         sa fie maxima. Este posibil ca oricate obiecte si bucati din obiecte sa fie
         introduse. (metoda Greedy)
         */
        private static int nrObiecte, G;
        private static int[] Valori;
        private static int[] Greutate;
        static void Main(string[] args)
        {
            Citire();

            Console.WriteLine();
            Console.Write("Greutatea maxima a rucsacului: ");
            G = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Valoarea maxima ce poate incapea in rucsac: ");
            Console.WriteLine("Metoda recursiva: ");
            Console.WriteLine(RucsacDiscret(G, Greutate, Valori, nrObiecte));
            Console.WriteLine();
            Console.WriteLine("Metoda iterativa: ");
            Console.WriteLine(RucsacDiscretIterativ(G, Valori, Greutate, nrObiecte));
            Console.ReadKey();
        }
        private static void Citire()
        {
            bool eroareCitireN = false;
            do
            {
                try
                {
                    Console.Write("Numarul de obiecte: ");
                    nrObiecte = int.Parse(Console.ReadLine());
                    Greutate = new int[nrObiecte];
                    Valori = new int[nrObiecte];
                    int index = 0;
                    bool eroare = false;
                    do
                    {
                        try
                        {
                            for (int i = index; i < nrObiecte; i++)
                            {
                                Console.WriteLine("Obiectul " + (i + 1));
                                Console.Write("Greutate: ");
                                Greutate[i] = int.Parse(Console.ReadLine());
                                Console.Write("Valoare: ");
                                Valori[i] = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                index++;
                            }
                            eroare = false;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Eroare. Ati introdus valori invalide.");
                            eroare = true;
                        }
                    } while (eroare);
                }
                catch (Exception)
                {
                    Console.WriteLine("Eroare.");
                }
            } while (eroareCitireN);
        }
        private static int RucsacDiscret(int g, int[] greutati, int[] valori, int n)
        {
            if (n == 0 || g == 0)
            {
                return 0;
            }
            if (greutati[n - 1] > g)
            {
                return RucsacDiscret(g, greutati, valori, n - 1);
            }
            else
            {
                return Max(valori[n - 1] + RucsacDiscret(g - greutati[n - 1], greutati, valori, n - 1), RucsacDiscret(g, greutati, valori, n - 1));
            }
        }
        private static int Max(int v1, int v2)
        {
            return (v1 > v2) ? v1 : v2;
        }
        private static int RucsacDiscretIterativ(int G, int[] valori, int[] greutate, int n)
        {
            if (n == 0 || G == 0) return 0;
            int[] vectorMax = new int[100];
            int k = 0;
            int valoare = 0;
            int greutate1 = 0;
            while (n > 0)
            {
                if (greutate[n - 1] > G)
                {
                    //Trecem la urmatorul obiect.
                    n -= 1;
                }
                else
                {
                    //In caz contrar avem 2 cazuri;
                    //1) Cand valoarea calculata pana in momentul dat este mai mica decat G
                    //2) Cand valoarea calculata depasteste G
                    valoare += valori[n - 1];
                    greutate1 += greutate[n - 1];
                    if (greutate1 > G)
                    {
                        //Cand valoarea este mai mare decat G,
                        valoare = valori[n - 1];
                        greutate1 = greutate[n - 1];
                        vectorMax[k] = valoare;
                    }
                    else
                    {
                        //Cand valoarea este mai mica decat G sau egala cu G, o inseram in vectorul valorilor
                        vectorMax[k] += valoare;
                    }
                    k++;
                    //Trecem la urmatorul obiect
                    n -= 1;
                }
            }
            //Returnam cea mai mare valoare din vector
            return vectorMax.Max();
        }
        }
    }
