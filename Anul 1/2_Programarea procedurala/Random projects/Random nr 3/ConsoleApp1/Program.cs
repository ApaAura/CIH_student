using System;

namespace ConsoleApp1
{
    class Program
    {
        struct Anexa
        {
            static double h ;
            static double w ;
            public void Cit()
            {
                Console.Write("h= ");
                h = double.Parse(Console.ReadLine());
                Console.Write("w= ");
                w = double.Parse(Console.ReadLine());
            }
            public double Arie()
            {
                return h*w;
            }
        }
        struct camera
        {
            static double h;
            static double w;
            static double m;
            public void Cit()
            {
                Console.Write("h= ");
                h = double.Parse(Console.ReadLine());
                Console.Write("w= ");
                w = double.Parse(Console.ReadLine());
                Console.Write("m= ");
                m = double.Parse(Console.ReadLine());
            }
            public double Arie()
            {
                return 2 * (h * w + h * m + m * w);
            }
        }
        static void Main(string[] args)
        {
            camera x= new camera() ;
            x.Cit();
            Anexa x1 = new Anexa();
            x1.Cit(); 
            Anexa x2 = new Anexa();
            x2.Cit();
            Console.WriteLine($"Arie: {x.Arie()-(x1.Arie()+x2.Arie())}");
        }
    }
}
