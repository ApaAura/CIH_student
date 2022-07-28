using System;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problema 4. Să se scrie un program care citește de la tastatură 
             un șir de numere naturale și determină media aritmetică a celor pare.
             */
            Console.Write("Dati numarul de elmente:");
            int elemente = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introdu {elemente} numere intregi");
            int[] mas = new int[elemente];
            int pare = 0;
            int suma = 0;
            for (int i = 0; i < elemente; i++)
            {
                Console.Write($"Numarul {i + 1}:");
                mas[i] = int.Parse(Console.ReadLine());
                if (mas[i]%2==0)
                {
                    pare++;
                    suma += mas[i];
                }
            }
            if (pare == 0)
            {
                Console.WriteLine("nu exista");
            }
            else
            {
                Console.WriteLine($"Media aritmetica a numerelor este: {suma/pare:F2}");
            }
            Console.ReadKey();



        }
    }
}
