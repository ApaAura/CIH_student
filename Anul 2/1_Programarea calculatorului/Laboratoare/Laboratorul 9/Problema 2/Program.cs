using System;
using System.IO;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
         /*
         Programul pentru minimizarea timpului de asteptare 
         al unui client pentru a fi deservit la o statie.
         */
        static void Main(string[] args)
        {
            
            using (StreamReader rd=new StreamReader("date.in"))
            {
                using (StreamWriter wr=new StreamWriter("date.out"))
                {
                    int nrClienti;
                    nrClienti = int.Parse(rd.ReadLine());
                    int[] TimpAsteptare = new int[nrClienti];
                    for (int i = 0; i < nrClienti; i++)
                    {
                        TimpAsteptare[i] = int.Parse(rd.ReadLine());
                    }
                    List<int> timpClient = new List<int>();
                    for (int i = 0; i < nrClienti; i++)
                    {
                        int Asteptare;
                        Console.WriteLine($"Timpul de asteptare client {i}: {Asteptare = TimpAsteptare[i]}");
                        timpClient.Add(Asteptare);
                    }
                    Ordonare(timpClient);
                    wr.WriteLine($"Timpul total de asteptare are voaloarea minima: {CalculTimpMinim(timpClient)}");
                    Console.WriteLine($"Timpul total de asteptare are voaloarea minima: {CalculTimpMinim(timpClient)}");
                    Console.WriteLine("Datele au fost inscrise cu succes !");
                }
            }
        }
        private static object CalculTimpMinim(List<int> timpClient)
        {
            int s = 0;
            Console.WriteLine("Ordinea de desrvire este: ");
            for (int i = 1; i <= timpClient.Count; i++)
            {
                s += (timpClient.Count - 1 + 1) * timpClient[i - 1];
                Console.Write($"{timpClient[i-1]} ");
            }
            Console.WriteLine();
            return s;
        }
        private static void Ordonare(List<int> timpClient)
        {
            //Metoda bulelor
            int k,aux;
            do
            {
                k = 0;
                for (int i = 0; i < timpClient.Count-1; i++)
                {
                    if (timpClient[1]>timpClient[i+1])
                    {
                        aux = timpClient[i];
                        timpClient[i] = timpClient[i + 1];
                        timpClient[i + 1] = aux;
                        k = 1;
                    }
                }
            } while (k==1);
        }
    }
}
