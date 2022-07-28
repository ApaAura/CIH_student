using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizați o aplicație de consolă.
             De la tastatură se citește un număr pozitiv, mai mic sau egal cu 100.
             Elaborați un program care va afișa numărul citit cu cifre romane.
            */

            int a;
            Console.Write("Introduceti un numar : ");
            a = int.Parse(Console.ReadLine());
            
            
            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
                case 10: Console.Write("X"); break;


                default: Console.Write("Numarul nu poate fi citit "); break;
            }
            Console.ReadKey();
        }
    }
}
