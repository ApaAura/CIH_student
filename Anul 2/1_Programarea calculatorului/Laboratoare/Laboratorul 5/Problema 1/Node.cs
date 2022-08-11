using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_1
{
    class Node
    {
        public int Value { get; set; }
        public Node RigthNode { get; set; }
        public Node LeftNode { get; set; }
        public Node(int value) 
        {
            this.Value = value;
        }
        public void PrintPretty(string index, bool last)
        {
            Console.Write(index);
            if (last)
            {
                Console.Write("└─");
                index += " ";
            }
            else
            {
                Console.Write("├─");
                index += "|";
            }
            Console.WriteLine(Value);

            var children = new List<Node>();
            if (this.LeftNode!=null)
            {
                children.Add(this.LeftNode);
            }
            if (this.RigthNode!=null)
            {
                children.Add(this.RigthNode);
            }
            for (int  i = 0;  i <children.Count;  i++)
            {
                children[i].PrintPretty(index, i == children.Count - 1);
            }
        }
    }
}
