using System;

namespace Problema2
{
    class Program
    {
        /*Într-o tabără numărul de băieţi este cu 10 mai mare decât cel al fetelor.
         * De la tastatură se citeşte numărul de fete. Elaboraţi un program prin 
          intermediul căruia se va determina numărul elevilor din tabără. 
          
            Exemplu: date de intrare: 50 date de ieşire: 110.
          */
        static void Main(string[] args)
        {
            int numarFete;
            int numarBaieti;
            int numarTotal;
           
            Console.WriteLine("Introdu numarul de fete: ");
            numarFete = int.Parse(Console.ReadLine());
            numarBaieti = numarFete + 10;
            numarTotal = numarFete + numarBaieti;
            Console.WriteLine($"Numarul total de copii: {numarTotal}");
            Console.ReadKey();
        }
    }
}
