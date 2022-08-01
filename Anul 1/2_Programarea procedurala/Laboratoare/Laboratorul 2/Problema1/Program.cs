using System;
using System.IO;

namespace Problema1
{
    struct Elev
    {
        public string nume;
        public double media;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elev[] listaelevi = new Elev[5];
            Console.Write("Introdu lista elevilor:");
            for (int i = 0; i < listaelevi.Length; i++)
            {
                Console.Write("Introdu numele: ");
                listaelevi[i].nume = Console.ReadLine();
                Console.Write("Introdu media: ");
                listaelevi[i].media = double.Parse(Console.ReadLine());
            }
            using (BinaryWriter stream=new BinaryWriter(File.Open("Elevi.dat", FileMode.OpenOrCreate)))
            {
                foreach (Elev el in listaelevi)
                {
                    stream.Write(el.nume);
                    stream.Write(el.media);
                }
                Console.WriteLine("Lista este scrisa in fisier!");
            }
            Elev[] lista = new Elev[5];
            using (BinaryReader stream = new BinaryReader(File.Open("Elevi.dat",FileMode.Open)))
            {
                int i = 0;
                Console.WriteLine("Lista elevilor: ");
                while (stream.BaseStream.Position != stream.BaseStream.Length)
                {
                    lista[i].nume = stream.ReadString();
                    lista[i].media = stream.ReadDouble();
                    Console.WriteLine($"Numele: {lista[i].nume}, Media: {lista[i].media}");
                    if (i==lista.Length-1)
                    {
                        break;
                    }
                    i++;
                }
            }
            Console.ReadKey();

        }
    }
}
