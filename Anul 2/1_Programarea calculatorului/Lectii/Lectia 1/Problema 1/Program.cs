using System;
using System.Collections.Generic;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
