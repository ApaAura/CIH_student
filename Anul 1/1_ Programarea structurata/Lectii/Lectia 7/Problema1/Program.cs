using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            char Operator;
            Console.Write("Operator : ");
            Operator = char.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+': Console.WriteLine($"{a} + {b} = {a+b}"); break;
                case '-': Console.WriteLine($"{a} - {b} = {a-b}"); break;
                case '*': Console.WriteLine($"{a} * {b} = {a*b}"); break;
                case '/': Console.WriteLine($"{a} / {b} = {a/b}"); break;
                case '%': Console.WriteLine($"{a} % {b} = {a%b}"); break;
                default:
                    Console.WriteLine("Operator necunoscut\n0");
                    break;
            }
            Console.ReadKey();
        }
    }
}
