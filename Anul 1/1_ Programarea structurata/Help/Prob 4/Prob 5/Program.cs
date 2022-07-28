using System;

namespace Prob_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //De la tastatură vor fi citite lungimea și lățimea unui dreptunghi. 
            //Să se calculeze și să se afișeze perimetrul și aria acestui dreptunghi.
            Console.WriteLine("Introduceti dimensiunile dreptunghiului:");
            Console.WriteLine("Lungimea: ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Latimea: ");
            int l = int.Parse(Console.ReadLine());
            //Afisam perimetrul
            Console.WriteLine("Perimetrul dreptunghiului: {0}", L+l+l+L);
            //Afisam aria
            Console.WriteLine("Aria dreptunghiului: {0}", L*l);
        }
    }
}
