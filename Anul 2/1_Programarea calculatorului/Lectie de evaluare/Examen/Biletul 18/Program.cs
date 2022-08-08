using System;
using System.IO;
using System.Collections.Generic;

namespace Biletul_18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Biletul 18
            De elaborat o aplicatie ce citeste un sir de numere intregi din fisierul text cu numere NUMERE.IN.
            Completeaza o lista cu aceste numere si determina elementul maximal si minimal din aceasta structura
            si va scrie rezultatul in fisierul NUMERE.OUT.
            */
            StreamReader rd = new StreamReader("NUMERE.IN");
            {
                StreamWriter wr = new StreamWriter("NUMERE.OUT");
                {
                    List<int> lista = new List<int>();
                    int nrElemente = int.Parse(rd.ReadLine());
                    if (nrElemente==0)
                    {
                        Console.WriteLine("Nu au fost gasite elemente !");
                    }
                    else
                    {
                        for (int i = 0; i < nrElemente-1; i++)
                        {
                            lista.Add(int.Parse(rd.ReadLine()));
                        }
                    }
                    Console.WriteLine("Elementele listei: ");
                    foreach (int i in lista)
                    {
                        Console.Write(i + " ");
                    }
                    lista.Sort();
                    Console.WriteLine($"\n\nElementul maxim: {lista[0]}");
                    wr.WriteLine($"\n\nElementul maxim: {lista[0]}");
                    Console.WriteLine($"Elementul minim: {lista[lista.Count - 1]}");
                    wr.WriteLine($"\n\nElementul minim: {lista[lista.Count - 1]}");
                }
            }
        }
    }
}
