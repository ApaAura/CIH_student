using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 3. Se citesc numere de la tastatură până la apariția lui zero. 
             Să se determine suma celor pare.
              */

            Console.WriteLine($"Introdu numere intregi");
            int suma = 0;
            int nr = 1;
            while (nr != 0)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                {
                    suma += nr;
                }
            }
            if (suma == 0)
            {
                Console.WriteLine("Suma este 0");
            }
            else
            {
                Console.WriteLine($"Suma numerelor pare este: {suma}");
            }
            Console.ReadKey();
        }
    }
}
