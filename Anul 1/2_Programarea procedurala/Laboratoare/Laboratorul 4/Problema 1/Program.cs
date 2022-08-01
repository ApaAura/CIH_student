using System;
using System.Collections.Generic;

namespace Problema_1
{
    /*
     De creat o listă legată e conține informația despre calculatoare și volumul de memorie a
     lui. Să se șteargă din această listă calculatoarele cu volumul de memorie minim. Să se afișeze lista
     modificată.
     */
    struct Calculatoarele
    {
        public string Calculator;
        public int Memorie;
    }
    class Program
    {
        static public void TiparesteLista(List<Calculatoarele> lista)
        {
            foreach (var el in lista)
            {
                Console.WriteLine($"{el.Calculator} {el.Memorie}");
            }
        }
        static void Main(string[] args)
        {
            List<Calculatoarele> listaComp = new List<Calculatoarele>();
            int nr = int.Parse(Console.ReadLine());
            string denm;
            int mr;
            Console.WriteLine("Introduceti denumirea Calculatorului si volumul memoriei.");
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine($"Calculatorul {i}");
                Console.Write("Introduceti deumirea calculatorului: ");
                denm = Console.ReadLine();
                Console.Write("Introduceti volumul de memorie (GB): ");
                mr = int.Parse(Console.ReadLine());
                listaComp.Add(new Calculatoarele() { Calculator = denm, Memorie = nr });
            }
            Console.WriteLine();
            TiparesteLista(listaComp);
            int min= listaComp[0].Memorie;
            foreach (var el in listaComp)
            {
                if (el.Memorie > min) {min = el.Memorie; }
            }
            Console.WriteLine($"min {min}");
            Console.ReadKey();
        }
    }
}
