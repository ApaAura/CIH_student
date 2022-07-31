using System;
using System.Text;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             De creat un fisier cu denumirea orase.txt ce va contine denumirile a cinci orase,
              ce vor fi citite de la tastatura. De afisat la ecran continutul acestu fisier
            */
            string oras;
            StreamWriter fisierOrase = new StreamWriter("orase.txt");
            Console.WriteLine("Introdu denumirile a 5 orase:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Denumumirea orasului {i}: ");
                oras = Console.ReadLine();
                fisierOrase.WriteLine(oras);
            }
            fisierOrase.Close();
            /*StreamReader fOrase = new StreamReader("Orase.txt");
            while ((oras=fOrase.ReadLine())!=null)
            {
                Console.WriteLine(oras);
            }
            fOrase.Close();
            */
            using (StreamReader fo = new StreamReader("Orase.txt"))
            {
                Console.WriteLine(fo.ReadToEnd());
            }
                Console.ReadKey();
        }
    }
}
