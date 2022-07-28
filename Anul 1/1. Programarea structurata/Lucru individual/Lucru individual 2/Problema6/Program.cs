using System;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 6: Într-un vas sunt x litri de apă (x>0). 
             După fiecare t minute, un sfert din cantitatea de apă se evaporă.
             Să se determine după câte minute vor rămâne în vas cel mult y litri de apă. 
             Exemplu: S-au citit x=100, t=15, y=20. Sunt necesare T=90 minute pentru ca 
             în vas să rămănă cel mult y=20 litri de apă.
             */
            Console.Write("Introduceti volumul initial de apa, x= ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Introduceti timpul necesar evaporarii a 1/4 volum, t= ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Introduceti volumul de apa ramas, y= ");
            int y = int.Parse(Console.ReadLine());
            int cicles = 0;
            while (x > y)
            {
                x *= 0.75;
                cicles++;
            }
            Console.WriteLine($"Sunt necesare { cicles * t} minute pentru ca în vas să rămănă cel mult {y} litri de apă.");
            Console.ReadKey();
        }
    }
}
