using System;
using System.Linq;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problema 1:
             Sa se determine cel mai mare numar care se poate forma 
             cu ajutorul cifrelor unui numar natural citit de la tastatura.
             */
            Console.WriteLine("Introduceti un numar: ");
            string nr = Console.ReadLine();
            int[] digits = new int[nr.Length];
            for (int i = 0; i < nr.Length; i++)
            {
                digits[i] = int.Parse($"{nr[i]}");
            }
            Array.Sort(digits);
            Array.Reverse(digits);
            string formated = "";
            for (int i = 0; i < nr.Length; i++)
            {
                formated += digits[i];
            }
            Console.WriteLine($"Numarul maxim format: {formated}");
            Console.ReadKey();
        }
    }
}
