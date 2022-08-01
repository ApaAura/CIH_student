using System;
using System.IO;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fisierul vector.in contine n numere intregi separate printr-un singur spatiu. primul numar
            reprezinta numarul de numere din fisier. Elaborati un program prin intermediun caruia
            primele k numere vor fi sortate descrescator, iar restul numerele crescator, k se citeste de 
            la tastatura
             */
            using (StreamReader fin = new StreamReader("vector.in"))
            {
                string[] arr = fin.ReadLine().Split(' ');
                int dimensiune = int.Parse(arr[0]);
                int[] number = new int[dimensiune];
                bool gasit;
                for (int i = 0; i < dimensiune; i++)
                {
                    number[i] = int.Parse(arr[i + 1]);
                }
                Console.Write("k: ");
                int k = int.Parse(Console.ReadLine());
                if (k > dimensiune || k < 1)
                {
                    Console.WriteLine("Numar invalid: ");
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
                }
                for (int i = 0; i < dimensiune; i++)
                {
                    Console.WriteLine(number[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
