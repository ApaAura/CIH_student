using System;
using System.Threading;

namespace ppp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            SwowSimplePercentage();
            Console.ReadKey();
        }
        private static void SwowSimplePercentage()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"\rProgress: {i}%");
                Thread.Sleep(25);
            }
            Console.Write("\rDone!               ");
        }
    }
}
