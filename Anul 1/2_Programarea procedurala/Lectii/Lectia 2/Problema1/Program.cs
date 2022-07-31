using System;
using System.IO;

namespace Problema1
{
    class Program
    {
        public static string fileName = "Nature.in";
        static void Main(string[] args)
        {
            int[] tabelNote = new int[]
            {
                5,
                7,
                8,
                9,
                10,
            };
            using (BinaryWriter fout = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                foreach (int note in tabelNote)
                {
                    fout.Write(note);
                }
            }
            Console.WriteLine("Valorile din fisierul binar au fost scrise");
            using (BinaryReader reader=new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine("Valorile din fisierul dat:");
                while (reader.PeekChar()>-1)
                {
                    int nota = reader.ReadInt32();
                    Console.Write($"{nota}");
                }
            }
            Console.ReadKey();
        }
    }
}
