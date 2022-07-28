using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieExpresii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" a) -1 + 4 * 6 = ");
            Console.WriteLine(-1 + 4 * 6);
            Console.Write(" b) (35 + 5) % 7 = ");
            Console.WriteLine((35 + 5) % 7);
            Console.Write(" c) 14 + -4 * 6 / 11 = ");

            Console.WriteLine(14 + -4 * 6 / 11);
            Console.Write(" d) 2 + 15 / 6 * 1 - 7 % 2 = ");
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
        }
    }
}
