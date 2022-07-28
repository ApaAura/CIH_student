using System;

namespace App2
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
            int pow = 1;
            //For method
            for (int i = 0; i < b; i++)
            {
                pow *= a;
            }
            Console.WriteLine($"For method: {a}^{b} = {pow}");
            //While method
            pow = 1;
            int state = 0;
            while (state<b)
            {
                pow *= a;
                state++;
            }
            Console.WriteLine($"While method: {a}^{b} = {pow}");
            //Do while method
            state = 0;
            pow = 1;
            do
            {
                pow *= a;
                state++;
            }
            while (state < b);
            Console.WriteLine($"Do while method: {a}^{b} = {pow}");
            Console.ReadKey();
        }
    }
}
