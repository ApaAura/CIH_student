using System;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             De la tastatură se citesc două numere întregi a şi b, şi o operaţie 
             aritmetică: ”+”, ”-”, ”*”, ”/”. Să se afişeze la ecran rezultatul operaţiei din a și b.
             */
            int a, b;
            //Citirea valorilor de la tastatura
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            char Operator;
            //Citirea operatorului
            Console.Write("Operator : ");
            Operator = char.Parse(Console.ReadLine());
            //Instructiunea de decizie multipla SWITCH
            switch (Operator)
            {
                case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
                case '/': Console.WriteLine($"{a} / {b} = {a / b}"); break;
                case '%': Console.WriteLine($"{a} % {b} = {a % b}"); break;
                default:
                    Console.WriteLine("Operator necunoscut\n0");
                    break;
            }
            //Citirea unei taste
            //Folosim pentru ca sa putem mesajul la ecran, daca nu consola se va inchede in catema milisecunde
            Console.ReadKey();
        }
    }
}
