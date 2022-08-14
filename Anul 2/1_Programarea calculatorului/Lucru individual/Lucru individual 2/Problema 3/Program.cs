using System;
using System.Text;

namespace Problema_3
{
    class Program
    {
        //Sa se afiseze in ordine alfabetica anagramele unui cuvint format din litere
        //distincte. (metoda Backtraking)
        public static void Main()
        {
            Console.WriteLine("Introduceti un cuvant: ");
            string cuvant = Console.ReadLine();
            char[] arr = cuvant.ToCharArray();
            char aux;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            StringBuilder s = new StringBuilder();
            foreach (var item in arr)
            {
                s.Append(item);
            }
            String str = s.ToString();
            int len = str.Length;
            Console.WriteLine("========================= ");
            generatePermutation(str, 0, len);

        }
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            return string.Join("", b);
        }
        public static void generatePermutation(String str, int start, int end)
        {
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    str = swapString(str, start, i);
                    generatePermutation(str, start + 1, end);
                    str = swapString(str, start, i);
                }
            }
        }
    }
}