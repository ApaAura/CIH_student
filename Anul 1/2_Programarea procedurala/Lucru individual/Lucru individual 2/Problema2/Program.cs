using System;
using System.IO;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fişierul vector.in conţine n numere întregi separate printr-un singur spaţiu. 
             Primul număr reprezintă numărul de numere din fişier.
             Elaboraţi un program prin intermediul căruia primele k numere vor fi sortate descrescător, 
             iar restul numerelor crescător, k se citeşte de la tastatură.
             */
            StreamReader Fish = new StreamReader("vector.in");
            string[] arr = Fish.ReadLine().Split(' ');
            int dimesiune = int.Parse(arr[0]);
            int[] number = new int[dimesiune];
            bool gasit;
            Fish.Close();
            for (int i = 0; i < dimesiune; i++)
            {
                number[i] = int.Parse(arr[i + 1]);
            }
            Console.Write("Introduceti K= ");
            int k = int.Parse(Console.ReadLine());
            if (k > dimesiune || k < 1)
            {
                Console.WriteLine("Numar invalid:");
            }
            else
            {
                do
                {
                    gasit = false;
                    for (int i = 0; i < k - 1; i++)
                    {
                        if (number[i] < number[i + 1])
                        {
                            int aux = number[i];
                            number[i] = number[i + 1];
                            number[i + 1] = aux;
                            gasit = true;
                        }
                    }
                } while (gasit);
                do
                {
                    gasit = false;
                    for (int i = k; i < dimesiune - 1; i++)
                    {
                        if (number[i] > number[i + 1])
                        {
                            int aux = number[i];
                            number[i] = number[i + 1];
                            number[i + 1] = aux;
                            gasit = true;
                        }
                    }

                } while (gasit);
            }
            for (int i = 0; i < dimesiune; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
