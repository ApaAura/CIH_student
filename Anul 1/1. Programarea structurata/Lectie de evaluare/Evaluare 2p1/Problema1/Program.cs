using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Într-un text dat, ce este citit de la tastatură să se determine numărul de proproziții. 
            În calitate de delimitatori ale propozițiilor se consideră următoarele simboluri: ”.”, ”!”, ”?” ”;”
            */

            //Citirea datelor de la tastatura 
            Console.WriteLine("Introduceti textul:");
            string s = Console.ReadLine().TrimEnd();
            char[] simboluri = {'.','!','?',';'};
            //Blocul de calcul
            string[] a = s.Split(simboluri);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            //Afisarea rezultatului 
            Console.WriteLine("In textul:\n{0}\nSunt {1} propozitii",s,a.Length);
            Console.ReadKey();
        }
    }
}
