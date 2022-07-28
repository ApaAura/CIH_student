using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuvant = Console.ReadLine();
            string vocale = "aeou";
            int nri = 0;
            bool flag = false;
            for (int i = 0; i < cuvant.Length; i++)
            {
                if (vocale.Contains(cuvant[i]))
                {
                    Console.WriteLine("NU");
                    flag = true;
                    break;
                }
                else 
                {
                    if (cuvant[i]=='i')
                    {
                        nri++;
                    }
                }
                if (nri == cuvant.Length)
                {
                    Console.WriteLine("NU");
                }
                else 
                {
                    if (!flag)
                    {
                        Console.WriteLine("DA");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
