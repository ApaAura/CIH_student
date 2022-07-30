using System;

namespace Problema_10
{
    class Program
    {
        static public int[] tabel;
        static public int suma = 0;
        static void Main(string[] args)
        {
            // Este dată mărime tabelară unidimensională A cu n elemente întregi. Determinați suma elementelor de pe 
            // pozițiile pare ale acestui tabel folosind o procedură ce primește tabelul ca parametru si reîntoarce suma elementelor.
            Console.Write("Introduceti numarul elementelor: ");
            int elemente = int.Parse(Console.ReadLine());
            tabel = Citire(elemente);
            Afisare();
            Suma(tabel);
        }
        private static void Suma(int[] tabel)
        {
            for (int i = 0; i < tabel.Length; i+=2)
            {
                suma += tabel[i];
            }
            Console.WriteLine($"Suma elementelor de pe pozitii pare: {suma}");
        }
        private static void Afisare()
        {
            for (int i = 0; i < tabel.Length; i++)
            {
                Console.Write(tabel[i]+" ");
            }
            Console.WriteLine();
        }
        private static int[] Citire(int elemente)
        {
            int[] mas = new int[elemente];
            Random el = new Random();
            for (int i = 0; i < elemente; i++)
            {
                mas[i] = el.Next(-100,100);
            }
            return mas;
        }
    }
}
