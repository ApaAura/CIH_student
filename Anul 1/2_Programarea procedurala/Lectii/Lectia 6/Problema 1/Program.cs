using System;
using System.Linq;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        /*
         De creat o stivă ce va conține informații despre lucrătorii unei companii: Numele lucrătorului, și salariul lui.
         Să se calculeze salariul mediu în companie și să se afișeze lista lucrătorilor ce au salariul mai mic ca cel mediu
         */
        struct Lucrator
        {
            string Nume;
            public int Salariu;
            public void Citire()
            {
                Console.Write("Nume client: ");
                Nume = Console.ReadLine();
                Console.Write("Suma: ");
                Salariu = int.Parse(Console.ReadLine());
            }
            public void Afisare()
            {
                Console.WriteLine("===========================");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Suma: {Salariu}");
                Console.WriteLine("===========================");
            }
        }
        static void Main(string[] args)
        {
            Stack<Lucrator> lucrator = new Stack<Lucrator>();
            Console.Write("Introduceti numarul de lucratori: ");
            int nr = int.Parse(Console.ReadLine());
            Lucrator nr1;
            for (int i = 0; i < nr; i++)
            {
                nr1 = new Lucrator();
                nr1.Citire();
                lucrator.Push(nr1);
            }
            // float SalariuMed =(float) lucrator.Average(x=>x.Salariu);
            double SumaSalariu = 0;
            foreach (Lucrator item in lucrator)
            {
                SumaSalariu += item.Salariu;
            }
            double SalariuMed = SumaSalariu / nr;
            List<Lucrator> salariuBun = new List<Lucrator>();
            foreach (var item in salariuBun)
            {
                if (item.Salariu < SalariuMed)
                {
                    salariuBun.Add(item);
                }
            }
            Console.Clear();
            Console.WriteLine($"Salariu mediu: {SalariuMed}");
            Console.WriteLine("Lista lucratorilor cu salariu mai mic decat cel mediu: ");
            foreach (Lucrator item in salariuBun)
            {
                item.Afisare();
            }
            Console.ReadKey();
        }
    }
}
