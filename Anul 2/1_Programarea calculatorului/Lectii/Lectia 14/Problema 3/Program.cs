using System;
using System.IO;
using System.Collections.Generic;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //De elaborat o aplicație ce citește un șir de numere întregi din fișierul text cu numele NUMERE.IN. Completează o 
            //coadă cu aceste numere și va adăuga valoarea 0 înaintea fiecărui element negativ și va scrie rezultatul în fișierul NUMERE.OUT.

            StreamReader rd = new StreamReader("numere.in");
            Queue<int> coada = new Queue<int>();
            string[] ln = rd.ReadLine().Split(' ');
            rd.Close();
            int nr;
            foreach (var item in ln)
            {
                nr = int.Parse(item);
                coada.Enqueue(nr);
            }
            Console.WriteLine("Elementele cozii: ");
            foreach (int i in coada)
            {
                Console.Write(i + " ");
            }
            Queue<int> coadaMod = new Queue<int>();
            foreach (int i in coada)
            {
                if (i>=0)
                {
                    coadaMod.Enqueue(i);
                }
                else
                {
                    coadaMod.Enqueue(0);
                    coadaMod.Enqueue(i);
                }
            }
            Console.WriteLine("\nCoada modificata: ");
            using (StreamWriter wr = new StreamWriter("numere.out"))
            {
                foreach (int i in coadaMod)
                {
                    Console.Write(i + " ");
                    wr.Write(i + " ");
                }
            }
           
        }
    }
}
