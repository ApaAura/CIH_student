using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
       /*
        Problema 2.
        1. De elaborate o aplicație ce va prelucra o listă unidirecțională de numere întregi:
        a) Va determina numărul elementelor impare
        b) Va determina elementul maxim dintre cele impare.
        c) Va adăuga valoarea 0 dup elementul maximal dintre cele impare
       */
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.Write("Introduceti numarul de elemente:  ");
            int nrElemente = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele: ");
            for (int i = 0; i < nrElemente; i++)
            {
                int element = int.Parse(Console.ReadLine());
                lista.Add(element);
            }
            NrElementeImpare(lista);
            ElMaxImp(lista);
        }
        private static void ElMaxImp(List<int> lists)
        {
            List<int> ElImpare = new List<int>();
            foreach (int i in lists)
            {
                if (i % 2 == 1)
                {
                    ElImpare.Add(i);
                }
            }
            int ElMax = 0;
            foreach (int i in ElImpare)
            {
                if (i>int.MinValue)
                {
                    ElMax = i;
                }
            }
            Console.WriteLine($"Elementul maxim dintre cele impare: {ElMax}");
            List<int> newList = new List<int>();
            foreach (int it in lists)
            {
                if (it==ElMax)
                {
                    newList.Add(0);
                    newList.Add(it);
                }
                else
                {
                    newList.Add(it);
                }
            }
            foreach (int i in newList)
            {
                Console.Write(i + " ");
            }
        }
        private static void NrElementeImpare(List<int> lists)
        {
            int NrElemente = 0;
            foreach (int i in lists)
            {
                if (i%2==1)
                {
                    NrElemente++;
                }
            }
            Console.WriteLine($"Numarul de elemente impare: {NrElemente}");
        }
    }
}
