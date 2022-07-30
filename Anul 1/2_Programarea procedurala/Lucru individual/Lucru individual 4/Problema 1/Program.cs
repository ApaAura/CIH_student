using System;
using System.IO;
namespace Problema_1
{
    class Program
    {
        static public string text;
        static void Main(string[] args)
        {
            // Fişierul date.in conţine un şir de caractere. Elaboraţi un program care 
            // va înlocui cifrele din şir cu semnul +. Rezultatul va fi afişat la ecran.
            using (StreamReader rd=new StreamReader("date.in"))
            {
                text = rd.ReadLine();
            }
            text = text.Replace('0', '+').Replace('1', '+').Replace('2', '+').Replace('3', '+').Replace('4', '+').Replace('5', '+')
                        .Replace('6', '+').Replace('7', '+').Replace('8', '+').Replace('9', '+');
            Console.WriteLine($"Textul modificat: {text}");
        }
    }
}
