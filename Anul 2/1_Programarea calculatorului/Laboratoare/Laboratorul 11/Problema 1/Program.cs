using System;
using System.IO;

namespace Problema_1
{
    class Program
    {
        //Determinarea elementului maxim prin tehnica Divide Et Impera
        static void Main(string[] args)
        {
            using (StreamReader rd = new StreamReader("date.in"))
            {
                using (StreamWriter wr = new StreamWriter("date.out"))
                {
                    int nrElemente;
                    nrElemente = int.Parse(rd.ReadLine());
                    if (nrElemente==0)
                    {
                        Console.WriteLine("Nu au fost gasite elemente !");
                    }
                    else
                    {
                        int[] vector = new int[nrElemente];
                        for (int i = 0; i < nrElemente; i++)
                        {
                            vector[i] = int.Parse(rd.ReadLine());
                        }
                        AfisareVector(vector);
                        Console.WriteLine("\n\n*****************************");
                        wr.WriteLine("*****************************");
                        Console.WriteLine($"Elementul maxim este {MaxDivide(vector, 0, nrElemente-1)} ");
                        wr.WriteLine($"Elementul maxim este {MaxDivide(vector, 0, nrElemente - 1)} ");
                        Console.WriteLine("*****************************");
                        wr.WriteLine("*****************************");
                        Console.WriteLine("Elementele au fost inscrise cu succes !");
                    }
                }
            }
        }
        private static int MaxDivide(int[] vector, int left, int right)
        {
            int els, eld, mijloc;
            if (left==right)
            {
                return vector[left];
            }
            else
            {
                mijloc = (left+right) / 2;
            }
            els = MaxDivide(vector, left, mijloc);
            eld = MaxDivide(vector, mijloc + 1, right);
            if (els>eld)
            {
                return els;
            }
            else
            {
                return eld;
            }
        }
        private static void AfisareVector(int[] vector)
        {
            Console.WriteLine("Elementele vectorului: ");
            foreach (int i in vector)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
