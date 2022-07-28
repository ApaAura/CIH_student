using System;

namespace Prob_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //De la tastatură este citit un număr natural n. Să se calculeze şi să se afişeze suma numerelor impare pînă la acest n dat.
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int Suma = 0;
            for (int i = 0; i <= n; i++)
            {
                //verificam daca numarul este impar
                if (i%2==1)
                {
                    Suma += i;
                }
            }
            Console.WriteLine("Suma numerelor impare pana la {0} este {1}",n, Suma);
        }
    }
}
