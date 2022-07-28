using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textRezultant = "";
            for (int i = 0; i < text.Length; i++)
            {
               
                    switch (text[i])
                    {
                        case 'a':textRezultant += "A";break;
                        case 'e': textRezultant += "E"; break;
                        case 'i': textRezultant += "I"; break;
                        case 'o': textRezultant += "O"; break;
                        case 'u': textRezultant += "U"; break;
                        default:
                        textRezultant += text[i];
                            break;
                    }
            }
            //Afisarea textului rezultant
            Console.WriteLine(textRezultant);
            Console.ReadKey();

        }
    }
}
