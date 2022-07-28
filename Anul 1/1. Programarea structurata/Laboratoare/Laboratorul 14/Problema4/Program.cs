using System;
using System.Text;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este dat textul unui mesaj, de afișat la ecran doar cuvintele ce vor conține un subșir citit de la tastatură.

            //Citirea datelor de la tastatura
            Console.WriteLine("Introduceti textul: ");
            string[] ln = Console.ReadLine().Split(" ");
            Console.WriteLine("Introduceti subsirul cautat: ");
            string x = Console.ReadLine();
            //Algoritmul de rezolvare
            foreach(string st in ln)
            {
                if (st.Contains(x))
                {
                    Console.Write(st+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
