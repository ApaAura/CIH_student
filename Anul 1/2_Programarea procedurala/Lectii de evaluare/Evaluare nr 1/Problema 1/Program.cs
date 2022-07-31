using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Problema_1
{
    /*
     De elaborat o aplicație ce citește un șir de numere întregi din fișierul text cu
     numele NUMERE.IN. Completează o lista cu aceste numere și calculati produsul
     elementul maxim si minim din această structură și va scrie rezultatul în fișierul
     NUMERE.OUT.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int prod;
            using (StreamReader rd = new StreamReader("NUMERE.in"))
            {
                string[] citite_din_fisier;
                citite_din_fisier = rd.ReadLine().Split(' ');

                foreach (var item in citite_din_fisier)
                {
                    lista.Add(int.Parse(item));
                }
                Console.WriteLine("Elementele listei: ");
                foreach (var item in citite_din_fisier)
                {
                    Console.Write(item+" ");
                }
                int max = lista.Max();
                int min = lista.Min();
                prod = max * min;
            }
            using (StreamWriter wr = new StreamWriter("NUMERE.out"))
            {
                wr.WriteLine($"Produsul dintre elementul maxim si minim: {prod}");
            }
            Console.WriteLine($"\n\nProdusul dintre elementul maxim si minim: {prod}");
            Console.WriteLine("Datele au fost inscrise cu succes in NUMERE.out!");
        }
    }
}
