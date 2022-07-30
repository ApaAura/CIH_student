using System;
using System.IO;

namespace Problema_4
{
    class Program
    {
        static public int L;
        static public int l;
        static void Main(string[] args)
        {
            // Dintr-un fișier date.in vor fi citite lungimea și lățimea unui dreptunghi. 
            // Să se calculeze și să se afișeze la ecran aria acestui dreptunghi, folosind o procedură ce primește ca parametru aceste valori .
            using (StreamReader rd = new StreamReader("date.in"))
            {
                string[] line = rd.ReadLine().Split(" ");
                L = int.Parse(line[0]);
                l = int.Parse(line[1]);
            }
            Arie(l,L);
        }
        private static void Arie(int l1, int l2)
        {
            Console.WriteLine($"Aria dreptunghiului este {l1*l2}");
        }
    }
}
