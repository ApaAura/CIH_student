using System;
using System.IO;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //De elaborat o aplicație ce citește un șir de numere întregi din fișierul text cu numele NUMERE.IN. Completează o stivă cu aceste 
            //numere și determină elementul maxim din această structură și va scrie rezultatul în fișierul NUMERE.OUT

            StreamReader rd = new StreamReader("numere.in");
            Stack<int> Stiva = new Stack<int>();
            string[] ln = rd.ReadLine().Split(' ');
            rd.Close();
            int max = int.MinValue;
            int nr;
            foreach (var item in ln)
            {
                nr = int.Parse(item);
                if (nr>max)
                {
                    max = nr;
                }
                Stiva.Push(nr);
            }
            Console.WriteLine("Elementele stivei: ");
            foreach (int i in Stiva)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine($"\nElementul maximal: {max}");
            using (StreamWriter wr = new StreamWriter("numere.out"))
            {
                wr.WriteLine(max);
            }
        }
    }
}
