using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        /*
          Date fiind 6 numere castigatoare la loto si o lista inlantuita cu numere alese
          de un jucator, sa se afiseze cate numere a ghicit jucatorul.
         */
        static void Main(string[] args)
        {
            List<int> win = new List<int>();
            List<int> user = new List<int>();
            Random element = new Random();
            for (int i = 0; i < 6; i++)
            {
                win.Add(element.Next(0, 100));
            }
            Console.WriteLine("Introduceti 6 numere: ");
            for (int i = 0; i < 6; i++)
            {
                user.Add(int.Parse(Console.ReadLine()));
            }
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (win.Contains(user[i]))
                {
                    count++;
                }
            }
            Console.Clear();
            Console.WriteLine("Numerele castigatoare: ");
            foreach (int i in win)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nNumerele alese: ");
            foreach (int i in user)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nAti ghicit {count} numere.");
        }
    }
}
