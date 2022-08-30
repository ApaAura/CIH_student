using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal interface ISolution
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public bool Existence(); //determina daca exista solutie 
    }
}
