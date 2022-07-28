using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Prețul unei convorbiri telefonice constituie – p lei. Dacă durata convorbirii depășește 5 minute, 
            atunci pentru timpul rămas se aplică o reducere de 20%.
            Elaborați o aplicație ce va determina costul convorbirii telefonice de durata dată t.
              */

            int p, t;
            Console.Write("Pretul pentru o minuta =  ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Timpul convorbirii = ");
            t = int.Parse(Console.ReadLine());

            if(t>5)
            {
                Double B = ((5 * p) + ((t - 5) * (p * 0.2)));
                Console.WriteLine($"Costul convorbirii este {B}",B);
            }
            else
            {
                Double B = (t * p);
                Console.WriteLine($"Costul convorbirii este {B}", B);
            }
            Console.ReadKey();
        }
    }
}
