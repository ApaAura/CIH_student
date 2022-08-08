using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
       /* 
        * Problema 1
        1. De elaborate o aplicație ce va prelucra o listă unidirecțională de numere întregi:
        a) va determina numărul elementelor negative.
        b) va determina elementul maximal dintre elementele pozitive/negative.
        c) Va adăuga valoarea 0 înaintea fiecărui element negativ și va afișa lista modificată.
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
            NrElemNegative(lista);
            ElMax(lista);
            ElNegativMaxim(lista);
            Valoare(lista);
            
        }
        private static void Valoare(List<int> lists)
        {
            List<int> newList = new List<int>();
            foreach (int i in lists)
            {
                if (i<0)
                {
                    newList.Add(0);
                    newList.Add(i);
                }
                else
                {
                    newList.Add(i);
                }
            }
            foreach (int i in newList)
            {
                Console.Write(i+" ");
            }
        }
        private static void ElNegativMaxim(List<int> lists)
        {
            List<int> NrNegative = new List<int>();
            foreach (int i in lists)
            {
                if (i<0)
                {
                    NrNegative.Add(i);
                }
            }
            int ElMax = 0;
            foreach (int i in NrNegative)
            {
                if (i>int.MinValue)
                {
                    ElMax = i;
                }
            }
            Console.WriteLine($"Elementul negativ maxim: {ElMax}");
        }
        private static void ElMax(List<int> lists)
        {
            int ElM = 0;
            foreach (int i in lists)
            {
                if (i>int.MinValue)
                {
                    ElM = i;
                }
            }
            Console.WriteLine($"Elementul maxim: {ElM}");
        }
        private static void NrElemNegative(List<int> lists)
        {
            int count = 0;
            foreach (int i in lists)
            {
                if (i<0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numarul de elemente negative: {count}");
        }
    }
}
