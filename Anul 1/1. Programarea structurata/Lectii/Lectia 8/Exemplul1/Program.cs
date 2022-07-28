using System;

namespace Exemplul1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma primelor n numnere 
            //s=2+4+6+...2n

            int numar;
            Console.Write("Introduceti un numar: ");
            numar = int.Parse(Console.ReadLine());

            int suma = 0;
            Console.WriteLine($"Suma primelor {numar} valori");
            for (int i = 2; i < numar; i += 2)
            {
                Console.WriteLine($"{suma}+{i}={suma += i}");
            }
            Console.ReadKey();
        }
    }
}
