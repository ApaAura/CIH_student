using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        /*
         Să se creeze o listă legată cu elemente reale. Să se elimine din această 
         listă elementele negative. Să se afișeze această listă modificată.
         */
        static void Main(string[] args)
        {
            List<double> numere = new List<double>();
            Console.Write("Introduceti numarul de elemente: ");
            int nr = int.Parse(Console.ReadLine());
            Random el = new Random();
            for (int i = 0; i < nr; i++)
            {
                double element = el.Next(-100,100);
                numere.Add(element);
            }
            Console.Clear();
            Console.WriteLine("Elementel listelei: ");
            foreach (double item in numere)
            {
                Console.Write(item+" ");
            }
            List<double> elNegative = new List<double>();
            Console.WriteLine("\nElementele negative ale listei: ");
            foreach (double item in numere)
            {
                if (item<0)
                {
                    elNegative.Add(item);
                }
            }
            foreach (double item in elNegative)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
