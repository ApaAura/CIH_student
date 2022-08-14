using System;
using System.Collections.Generic;

namespace Problema_3
{
    class Program
    {
        /*
         Pentru o listă  simplu înlănţuită ale cărei componente întregi se citesc de la tastatură să se realizeze următoarele prelucrări:  
            Să se dubleze valoarea ultimului număr par din listă
            Să se tripleze valoarea primului număr par din listă
            Să se micşoreze cu o unitate valoarea penultimului număr par din listă.
         */
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                list.Add(m);
            }
            List<int> elPare = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (list[i]%2==0)
                {
                    elPare.Add(list[i]);
                }
            }
            Console.Clear();
            Console.WriteLine("Elementele listei: ");
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine($"\nSa se dubleze valoarea ultimului numar par din lista: {elPare[elPare.Count-1]*2}");
            Console.WriteLine($"Sa se tripleze valoarea primului numar par din lista: {elPare[0]*3}");
            Console.WriteLine($"Sa se micsoreze cu o unitate valoarea penultimului numar din lista: {elPare[elPare.Count-1]-1}");
        }
    }
}
