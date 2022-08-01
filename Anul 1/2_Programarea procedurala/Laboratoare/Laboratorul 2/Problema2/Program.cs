using System;
using System.IO;

namespace Problema2
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
            
           // Să se afișeze la ecran lista elevilor cu media mai mare ca 5 și lista elevilor restanțieri.
            
            Elev[] listaelevi = new Elev[5];
            Console.Write("Introdu lista elevilor:");
            for (int i = 0; i < listaelevi.Length; i++)
            {
                Console.Write("\nIntrodu numele: ");
                listaelevi[i].nume = Console.ReadLine();
                Console.Write("Introdu media: ");
                listaelevi[i].media = double.Parse(Console.ReadLine());
            }
            using (BinaryWriter stream = new BinaryWriter(File.Open("Elevi.dat", FileMode.OpenOrCreate)))
            {
                foreach (Elev el in listaelevi)
                {
                    stream.Write(el.nume);
                    stream.Write(el.media);
                }
            }
            Elev[] lista = new Elev[5];
            using (BinaryReader stream = new BinaryReader(File.Open("Elevi.dat", FileMode.Open)))
            {
                int i = 0;
                while (stream.BaseStream.Position != stream.BaseStream.Length)
                {
                    lista[i].nume = stream.ReadString();
                    lista[i].media = stream.ReadDouble();
                    if (i == lista.Length - 1)
                    {
                        break;
                    }
                    i++;
                }
            }
            Console.WriteLine("\nLista elevilor admisi");
            for (int i = 0; i < listaelevi.Length; i++)
            {
                if (listaelevi[i].media>=5)
                {
                    Console.WriteLine($"{listaelevi[i].nume} {listaelevi[i].media}");
                }
            }
            Console.WriteLine("Lista elevilor restantieri");
            for (int i = 0; i < listaelevi.Length; i++)
            {
                if (listaelevi[i].media < 5)
                {
                    Console.WriteLine($"{listaelevi[i].nume} {listaelevi[i].media}");
                }
            }
            Console.ReadKey();
        }
    }
}


        
          


