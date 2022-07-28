using System;
using ClassLibrary;

namespace Metode_template
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Citire();
            Class1.Afisare();
            Class1.Pare();
            Console.WriteLine($"\nSuma elementelor pare: {Class1.Suma()}"); 
            Console.ReadKey();
        }
    }
}