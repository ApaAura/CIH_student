using System;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            De la tastatură se întroduce coordonatele unui punct din planul de coordonate A(x, y).
            Să se determine în ce cuadrant se află acest punct.
            */

            int x,y;
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Cadranul I");
                }
                else
                {
                    Console.WriteLine("Cadranul IV");
                }
            }
            if(x < 0)
            {
                if(y < 0)
                {
                    Console.WriteLine("Cadranul II");
                }
                else
                {
                    Console.WriteLine("Cadranul III");
                }
            }
            Console.ReadKey();
        }
    }
}
