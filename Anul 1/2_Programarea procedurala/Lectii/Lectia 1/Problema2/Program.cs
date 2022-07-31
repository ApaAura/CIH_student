using System;
using System.Text;
using System.IO;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creati un fisier numbers.txt si scrieti numerele naturale de la 1 la 50 separate prin virgula 
            StreamWriter fisiernumbers = new StreamWriter("numbers.txt");
            Console.WriteLine("Numerele de la 1 la 50: ");
            fisiernumbers.WriteLine("Numerele de la 1 la 50: ");
            for (int i = 1; i <= 50; i++)
            {
                Console.Write($"{i}, ");
                fisiernumbers.Write($"{i}, ");
            }
            fisiernumbers.Close();

        }
    }
}
