using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_5
{
    struct Client
    {
        string Nume_Client;
        public int Suma;
        public void Citire()
        {
            Console.Write("Nume client: ");
            Nume_Client = Console.ReadLine();
            Console.Write("Suma: ");
            Suma = int.Parse(Console.ReadLine());
        }
        public void Afisare()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"Nume: {Nume_Client}");
            Console.WriteLine($"Suma: {Suma}");
            Console.WriteLine("===========================");
        }
    }
    class Program
    {
        /*
         De creat o coadă cu informația despre clienții unei bănci: Numele clientului, 
        și suma pe cont. Să se determine numărul clienților băncii, la care suma pe cont
        depășește 10000 MDL. Să se afișeze lista acestor clienți.
         */
        static void Main(string[] args)
        {
            Queue<Client> banca = new Queue<Client>();
            Console.Write("Introduceti numarul de clienti: ");
            int n = int.Parse(Console.ReadLine());
            Client nr1;
            for (int i = 0; i < n; i++)
            {
                nr1 = new Client();
                nr1.Citire();
                banca.Enqueue(nr1);
            }
            List<Client> banosi = new List<Client>();
            foreach (Client i in banca)
            {
                if (i.Suma>10000)
                {
                    banosi.Add(i);
                }
            }
            Console.Clear();
            Console.WriteLine("Lista clientilor cu cel putin 10 000 lei in cont: ");
            foreach (var item in banosi)
            {
                item.Afisare();
            }
        }
    }
}


