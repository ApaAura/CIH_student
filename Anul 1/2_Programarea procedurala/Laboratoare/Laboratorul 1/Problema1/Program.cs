using System;
using System.IO;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fisierul date.in contine 3 numere intregi separate printr-un singur spatiu. 
            Sa se elaboreze un program care va afisa aceste numere unul sib altul, 
            afisand in dreptul fiecaruia anul dintre cuvintele PAR sau IMPAR.
            Rezultatul va fi afisat la ecarn cat si in fisieul date.out
             */
            StreamReader fNumere = new StreamReader("date.in");
            string[] stNumere = fNumere.ReadLine().Split(' ');
            fNumere.Close();
            int num1, num2, num3;
            num1 = int.Parse(stNumere[0]);
            num2 = int.Parse(stNumere[1]);
            num3 = int.Parse(stNumere[2]);
            using (StreamWriter fRezultat = new StreamWriter("date.out"))
            {
                if (num1 % 2 == 1)
                {
                    fRezultat.WriteLine($"{num1} - IMPAR");
                    Console.WriteLine($"{num1} - IMPAR");
                }
                else
                {
                    fRezultat.WriteLine($"{num1} - PAR");
                    Console.WriteLine($"{num1} - PAR");
                }
                if (num2 % 2 == 1)
                {
                    fRezultat.WriteLine($"{num2} - IMPAR");
                    Console.WriteLine($"{num2} - IMPAR");
                }
                else
                {
                    fRezultat.WriteLine($"{num2} - PAR");
                    Console.WriteLine($"{num2} - PAR");
                }
                if (num3 % 2 == 1)
                {
                    fRezultat.WriteLine($"{num3} - IMPAR");
                    Console.WriteLine($"{num3} - IMPAR");
                }
                else
                {
                    fRezultat.WriteLine($"{num3} - PAR");
                    Console.WriteLine($"{num3} - PAR");
                }
            }
            Console.ReadKey();



        }
    }
}
