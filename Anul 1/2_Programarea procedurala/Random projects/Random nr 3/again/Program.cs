using System;

namespace again
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dati un sir de carcatere");
            string s = Console.ReadLine();
            string r = Reverse(s, s.Length-1);
            Console.WriteLine(r);
        }

        private static string Reverse(string s, int length)
        {
            if (length == -1) return "";
            else
            {
                return s[length] + Reverse(s, length-1);
            }
        }
    }
}
