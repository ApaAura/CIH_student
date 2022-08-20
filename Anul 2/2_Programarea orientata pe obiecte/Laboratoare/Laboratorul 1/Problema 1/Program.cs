using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerc cerculet1 = new Cerc();
            Console.Write("Introduceti lungimea razei a doua cercuri: ");
            Console.Write("\nCitirea datelor: Cerculet 1, Raza = ");
            cerculet1.Citire();

            Cerc cerculet2 = new Cerc();
            Console.Write("Citirea datelor: Cerculet 2, Raza = ");
            cerculet2.Citire();

            Console.WriteLine("Cerculet 1: ");
            cerculet1.Afisare();
            Console.WriteLine($"Lungimea cerculetului 1: {cerculet1.Lungime(cerculet1.lungimeaRazei)}");
            Console.WriteLine($"Suprafata cerculetului 1: {cerculet1.Suprafata(cerculet1.lungimeaRazei)}");
            Console.WriteLine();
            Console.WriteLine("Cerculet 2: ");
            cerculet2.Afisare();
            Console.WriteLine($"Lungimea cerculetului 2: {cerculet2.Lungime(cerculet2.lungimeaRazei)}");
            Console.WriteLine($"Suprafata cerculetului 2: {cerculet2.Suprafata(cerculet2.lungimeaRazei)}");
        }
    }
}
