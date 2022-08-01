using System;
using System.IO;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4.Fişierul cuvinte.in conţine mai multe cuvinte, separate printr - un singur spaţiu. Elaboraţi
            un program prin intermediul căruia la ecran se vor afişa cuvintele aranjate
            descrescător / crescător.
            */
            StreamReader fin = new StreamReader("cuvinte.in");
            string[] str = fin.ReadLine().Split(' ');
            bool gasit;
            do
            {
                gasit = false;
                for (int i = 0; i < str.Length-1; i++)
                {
                    if (str[i].Length > str[i + 1].Length)
                    {
                        string temp = str[i + 1];
                        str[i + 1] = str[i];
                        str[i] = temp;
                        gasit = true;
                    }
                }
            } while (gasit);
            fin.Close();
            Console.WriteLine("Cuvinte din fisier aranjate in Ordine crescatoare: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();
        }
    }
}
