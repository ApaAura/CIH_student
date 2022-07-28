using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /* De la tastatură se citesc două numere întregi a şi b. Elaboraţi un program prin
           intermediul căruia să se schimbe între ele valorile variabilelor a şi b. La ecran 
           se vor afişa noile valori ale lui a şi b. Rezolvați problema fără utilizarea
           variabilei auxiliare. */


            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Noile valori sunt a={a} b={b}");

            Console.ReadKey();
        }
    }
}
