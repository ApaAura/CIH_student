using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             De elaborat o aplicație ce va calcula adaosul la salariu pentru vechime în muncă, 
             dacă vecimea constitue de la 2 la 5 ani, adaosul este de 2 %, iar de la 5 ani la 10 ani – de 5 %.
             De la tastatură se întroduce salariul și vechimea în muncă, la ecran se va afișa suma salariului calculat. 
            */
            int a, b;
            Console.Write("Salariul = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Vechimea in munca = ");
            b = int.Parse(Console.ReadLine());

            if(b<2)
            {
                Console.WriteLine($"Adaosul la salariu este 0 salariul actual = {a} ",a);
            }
            else
            {
                if(b<5)
                {
                    double C;
                    C = 0.02 * a;
                    double X;
                    X = a + C;
                    Console.WriteLine($"Adaosul la salariu este {C}, salariul actual = {X}", C,X);
                }
                else
                {
                    double M;
                    M = 0.05 * a;
                    double Z;
                    Z = a + M;
                    Console.WriteLine($"Adaosul la salariu este {M}, salariul actual = {Z}", M,Z);
                }
            }
            Console.ReadKey();
        }
    }
}
