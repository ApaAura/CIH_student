using System;
using System.IO;
namespace Problema_1
{
    class Program
    {
        //Sa se fectueze plata unei sume S utilizand un numar minim de bancnote.
        static void Main(string[] args)
        {
            int suma;
            int[] nominal = new int[] { 1, 5, 10, 20, 50, 100, 200, 500, 1000 };
            using (StreamReader rd=new StreamReader("date.in"))
            {
                 suma = int.Parse(rd.ReadLine());
            }
            MetodaGreedy(suma, nominal);
            Console.ReadKey();
            Console.WriteLine($"Suma este: {suma}");
        }
        private static void MetodaGreedy(int suma, int[] nominal)
        {
            int t = 0;
            int i = nominal.Length - 1;
            using (StreamWriter wr = new StreamWriter("date.out"))
            {
                wr.WriteLine($"Suma: {suma}");
                Console.WriteLine($"Suma: {suma}");
            }
            while (suma>0)
            {
                if (suma>=nominal[i])
                {
                    Console.WriteLine($"{suma/nominal[i]} bancnote de valoarea {nominal[i]}");
                }
                t += suma / nominal[i];
                suma %= nominal[i];
                i--;
            }
            using (StreamWriter wr=new StreamWriter("date.out"))
            {
                wr.WriteLine($"Numarul de bancnote folosite {t}");
                Console.WriteLine($"\nNumarul de bancnote folosite {t}");
                Console.WriteLine("Datele au fost inscrise cu succes in fisier !");
            }

        }
    }
}
