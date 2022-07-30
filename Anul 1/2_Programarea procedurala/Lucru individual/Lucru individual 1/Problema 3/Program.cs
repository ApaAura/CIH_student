using System;
using System.IO;
namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3.Fişierul date.in conţine un şir de caractere.De la tastatură se citeşte un şir de caractere.
            Elaboraţi un program care va înlocui vocalele din şir cu spaţiu.Rezultatul va fi afişat la
            ecran cât şi în fişierul date.out.
            */
            using (StreamWriter wr = new StreamWriter("date.in"))
            {
                Console.WriteLine("Introduceti un sir de caractere: ");
                string sir = Console.ReadLine();
                wr.WriteLine(sir);
            }
            using (StreamReader rd = new StreamReader("date.in"))
            {
                string sir = rd.ReadLine();
                sir = sir.Replace('a', ' ')
                    .Replace('e', ' ')
                    .Replace('i', ' ')
                    .Replace('o', ' ')
                    .Replace('u', ' ')
                    .Replace('A', ' ')
                    .Replace('E', ' ')
                    .Replace('I', ' ')
                    .Replace('O', ' ')
                    .Replace('U', ' ');
                Console.WriteLine(sir);
                using (StreamWriter wr = new StreamWriter("date.out"))
                {
                    wr.WriteLine(sir);
                }
            }
        }
    }
}
