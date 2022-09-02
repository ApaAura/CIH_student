using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    abstract class Figure
    {
        public abstract double Square();
        public abstract double Border();
        public abstract bool Exists();
        public abstract string Str();
    }
}
