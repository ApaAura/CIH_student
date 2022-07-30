using System;
using System.IO;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fişierul cuvinte.in conţine mai multe cuvinte, separate printr - un singur spaţiu. 
            Elaboraţi un program prin intermediul căruia la ecran se vor afişa cuvintele aranjate descrescător/ crescător.
            */
            StreamReader fisa = new StreamReader("cuvinte.in");
            string[] text = fisa.ReadLine().Split(' ');
            fisa.Close();
            string aux;
            Console.Write("introduceti 'c' pentru aranjare crescatoare\nintroduceti 'd' pentru aranjare descrescatoare\n");
            char chose = char.Parse(Console.ReadLine());
            switch (chose)
            {
                case 'c': //utilizam metoda bulelor pentru soratrea crescatoare

                    for (int i = 0; i < text.Length - 1; i++)
                    {
                        for (int j = 0; j < text.Length; j++)
                        {
                            if (text[i].Length > text[i + 1].Length)
                            {
                                aux = text[i];
                                text[i] = text[i + 1];
                                text[i + 1] = aux;
                            }
                        }
                    }
                    Console.Write("\tTEXTUL SORTAT CRESCATOR\n");
                    for (int i = 0; i < text.Length; i++)
                    {
                        Console.Write("{0} ", text[i]);
                    }
                    break;


                case 'd'://utilizam metoda selectiei pentru sortarea descrescatoare

                    for (int i = 0; i < text.Length; i++)
                    {
                        int max = i;
                        for (int j = i + 1; j < text.Length; j++)
                        {
                            if (text[j].Length > text[max].Length) { max = j; }
                        }
                        aux = text[max];
                        text[max] = text[i];
                        text[i] = aux;
                    }
                    Console.Write("\tTEXTUL SORTAT DESCRESCATOR\n");
                    for (int i = 0; i < text.Length; i++)
                    {
                        Console.Write("{0} ", text[i]);
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
