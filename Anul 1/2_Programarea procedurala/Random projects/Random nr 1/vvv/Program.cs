using System;
using System.Threading;
using System.Threading.Tasks;

namespace vvv
{
    public static class Red
    {
        public async static void Logo()
        {
            string[] frames =
            {
                "_",
                "_",
                "_",
                "-",
                "`",
                "`",
                "'",
                "´",
                "-",
                "_",
                "_",
                "_"
            };
            const string logo = "Oi Aurica, AAaAi Aurica, Oi Aurica, AAaAi Aurica";
            await Task.Run(() =>
            {
                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        foreach (var item in frames)
                        {
                            Thread.Sleep(80);
                            Console.Title = item;
                        }
                    }
                    Console.Title = "";
                    foreach (var item in logo)
                    {
                        Console.Title += item;
                        Thread.Sleep(100);
                    }
                    Thread.Sleep(920);
                    for (int i = Console.Title.Length; i > 0; i--)
                    {
                        Thread.Sleep(100);
                        Console.Title = Console.Title.Substring(0, i);

                    }
                }
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Red.Logo();
            int x, y;
            Citire(out x,out y);
            AfisareF(x, y);
        }

        private static void Citire(out int x,out int y)
        {
            Console.WriteLine("Introduceti primul numar: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void AfisareF(int x, int y)
        {
            Console.WriteLine($"F={Calcule(x,y)}");
        }

        private static double Calcule(int x, int y)
        {
            double F = (Math.Pow(x,y)+Math.Pow(y,x)) / (Math.Pow(x,-y)+Math.Pow(y,-x));
                return  F;
        }
    }
    
}
