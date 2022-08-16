using System;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        //Sa se scrie functi ade inversare a unui sir folosind o stiva alocata dinamic.
        static void Main(string[] args)
        {
            string sirul;
            Console.Write("Introdu sirul: ");
            sirul = Console.ReadLine();
            Console.WriteLine($"Ati introdus sirul: {sirul}");
            Console.WriteLine($"Sirul inversat este {InversareSir(sirul)}");
            Console.ReadKey();
        }
        private static object InversareSir(string sir)
        {
            Stack<char> stiva = new Stack<char>();
            string sirInversat = "";
            for (int i = 0; i < sir.Length; i++)
            {
                stiva.Push(sir[i]);
            }
            while (stiva.Count>0)
            {
                sirInversat += stiva.Pop();
            }
            return sirInversat;
        }
    }
}
