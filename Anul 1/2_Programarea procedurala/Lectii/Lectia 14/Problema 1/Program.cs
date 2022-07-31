using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //De creat o listă legată de șiruri de caractere. Să se elimine din această
            //listă șirul de lungime maximală. Listele să fie afișate la ecran.
            Console.Write("Introduceti numarul de elemente: ");
            int nr = int.Parse(Console.ReadLine());
            LinkedList<string> lista = new LinkedList<string>();
            Console.WriteLine("Introduceti elementele: ");
            for (int i = 0; i < nr; i++)
            {
                string element = Console.ReadLine();
                lista.AddFirst(element);
            }
            Console.Clear();
            Console.WriteLine("Lista initiala: ");
            foreach (string item in lista)
            {
                Console.Write(item + "  ");
            }
            LinkedList<string> listaMod = new LinkedList<string>();
            int lungimeMax = 0;
            foreach (string m in lista)
            {
                if (m.Length>lungimeMax)
                {
                   lungimeMax = m.Length;
                }
            }
            foreach (string i in lista)
            {
                if (i.Length != lungimeMax)
                {
                    listaMod.AddFirst(i);
                }
            }
            Console.WriteLine("\nLista modificata: ");
            foreach (string item in listaMod)
            {
                Console.Write(item + "  ");
            }
            Console.ReadKey();
        }
    }
}
