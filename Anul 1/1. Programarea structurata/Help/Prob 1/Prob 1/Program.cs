using System;

namespace Prob_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este dat un tabel unidimensional cu maximum n elemente întregi, 
            //generate în mod aleatoriu. Să se determine media aritmetică a elementelor pozitive din acest tabel.

            Console.Write("Introduceti un numar de elemente: ");
            int n = int.Parse(Console.ReadLine());
            //declararea masivului
            int[] masiv = new int[n];
            //generarea elementelor aleatorii din intervalul -100 - 100
            Random el = new Random();
            for (int i = 0; i < n; i++)
            {
                masiv[i] = el.Next(-100, 100);
            }
            //Afisarea elementelor masivului
            Console.WriteLine("Elementele masivului: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(masiv[i]+" ");
            }
            //Initializam variabilele in cae va fi stocata:
            //suma elementelor mai mai ca 0
            int Suma = 0;
            //numarul elementelor mai mari ca 0
            int NrElemente = 0;
            for (int i = 0; i < n; i++)
            {
                if (masiv[i]>0)
                {
                    Suma += masiv[i];
                    NrElemente++;
                }
            }
            //Afisarea mediei aritmetice
            Console.WriteLine($"\nMedia aritmetica: {Suma/NrElemente}");
        }
    }
}
