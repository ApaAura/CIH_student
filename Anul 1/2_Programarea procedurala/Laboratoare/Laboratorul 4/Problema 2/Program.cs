using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_2
{
    public struct Carte
    {
        public string Denumire;
        public int Pret;
        public void Citire()
        {
            Console.Write("Denumire: ");
            Denumire = Console.ReadLine();
            Console.Write("Pret: ");
            Pret = int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"Denumirea cartii: {Denumire}");
            Console.WriteLine($"Pret: {Pret}");
            Console.WriteLine("===========================");
        }
    }
    class Program
    {
        /*
         De creat o coadă ce conține informație despre denumirea cărților și prețul lor. Să se afișeze
         coada respectiva și prețul mediu al cărților din coadă.
         */
        static void Main(string[] args)
        {
            Queue<Carte> carte = new Queue<Carte>();
            Console.Write("Introduceti numarul de carti: ");
            int n = int.Parse(Console.ReadLine());
            Carte nr1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Cartea {i+1}");
                nr1 = new Carte();
                nr1.Citire();
                carte.Enqueue(nr1);
            }
            //Pretul mediu cu ajutorul System.Linq
            float pretMediu = (float) carte.Average(x=>x.Pret);
            Console.Clear();
            Console.WriteLine("Elementele cozii: ");
            foreach (var i in carte)
            {
                i.Afisare();
            }
            Console.WriteLine($"\nPretul mediu: {pretMediu}");
        }
    }
}
