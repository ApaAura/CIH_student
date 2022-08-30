using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Animal
    {
        public string Porecla { get; set; }
        public virtual void Vorbeste()
        {
            Console.WriteLine("...");
        }
    }
    class Pisica : Animal
    {
        public override void Vorbeste()
        {
            Console.WriteLine("Meaw");
        }
    }
    class Caine : Animal
    {
        public override void Vorbeste()
        {
            Console.WriteLine("Ham");
        }
    }
}
