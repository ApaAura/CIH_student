using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write(" Întroduceți anul: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Anul " +year);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
               Console.WriteLine(" – este bisect ");
            else
               Console.WriteLine(" – nu este bisect ");
            Console.ReadLine();
        }
    }
}
