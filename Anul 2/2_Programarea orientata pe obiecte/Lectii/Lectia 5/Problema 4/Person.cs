using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    public class Person
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public void walk() { }
        public void eat() { }
        public void learn() { }
    }
    public class Programmer : Person
    {
        public string CompanyName { get; set; }
        public void Coding() { }
    }
    public class Dancer : Person
    {
        public string GroupName { get; set; }
        public void Dancing() { }
    }
    public class Singer : Person
    {
        public string BandName { get; set; }
        public void Singing() { }
        public void PlayGuitar() { }
    }
}
