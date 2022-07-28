using System;
using System.IO;
using System.Linq;

namespace Fisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader rd = new StreamReader("cihcrypt.in"))
            {
                using (StreamWriter wr = new StreamWriter("cihcrypt.out"))
                {
                    string line;
                    string valid = "Colegiul Iulia Hasdeu";
                    while ((line = rd.ReadLine()) != null)
                    {
                        if (line.Length == 8)
                        {
                            if (line.ToCharArray().Distinct().Count() >= 3)
                            {
                                if (line.ToLower().ToCharArray().Distinct().Intersect(valid.ToLower().ToCharArray().Distinct()).Count()== line.ToCharArray().Distinct().Count())
                                {
                                    wr.WriteLine(line);
                                }
                            }
                        }
                    }
                    Console.WriteLine("Programul a fost executat cu succes !");
                }
            }
        }
    }
}
