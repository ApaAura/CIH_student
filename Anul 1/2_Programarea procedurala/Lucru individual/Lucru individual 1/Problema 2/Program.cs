using System;
using System.IO;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2.Fişierul date.in conţine un şir de caractere.De la tastatură se citeşte un şir de caractere.
             Elaboraţi un program care va înlocui cifrele din şir cu semnul +.Rezultatul va fi afişat la
             ecran cât şi în fişierul date.out.
            */
            using (StreamWriter wr = new StreamWriter("date.in"))
            {
                Console.WriteLine("Introduceti un sir de caractere: ");
                string sir = Console.ReadLine();
                wr.WriteLine(sir);
            }
            using (StreamReader rd=new StreamReader("date.in"))
            {
                string sir = rd.ReadLine();
                sir =sir.Replace('0', '+')
                    .Replace('1', '+')
                    .Replace('2', '+')
                    .Replace('3', '+')
                    .Replace('4', '+')
                    .Replace('5', '+')
                    .Replace('6', '+')
                    .Replace('7', '+')
                    .Replace('8', '+')
                    .Replace('9', '+');
                Console.WriteLine(sir);
                using (StreamWriter wr = new StreamWriter("date.out"))
                {
                    wr.WriteLine(sir);
                }
            }
        }
    }
}
