using System;
using System.Linq;

namespace ClassLibrary
{
    public class Class1
    {
        static int[,] masiv = new int[4, 4];
        static public void Citire()
        {
            Random el = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                  masiv[i,j] = el.Next(-100, 100);
                }
            }
        }
        static public void Afisare()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(masiv[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        static public int[] elemente;
        static public void Pare()
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (masiv[i,j]%2==0)
                    {
                        s += $"{masiv[i,j]} ";
                    }
                }
            }
            Console.WriteLine("\nNumere pare:\n"+s);
            elemente = s.Trim().Split(" ").Select(x => int.Parse(x.Trim())).ToArray();
        }
        static public int Suma()
        {
            return elemente.Sum();
        }
    }
}
