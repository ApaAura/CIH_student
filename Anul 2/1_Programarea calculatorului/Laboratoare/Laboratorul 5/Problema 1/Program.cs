using System;

namespace Problema_1
{
    class Program
    {
        /*
         De elaborate o aplicație de console ce va complete un arbore binar și va afișa
         parcurgerea acestui arbore: preordine, postordine, inordine.
         */
        static void Main(string[] args)
        {
            Node node = new Node(4);
            AddNode(node, 2);
            AddNode(node, 5);
            AddNode(node, 1);
            AddNode(node, 3);
            AddNode(node, 7);
            AddNode(node, 6);
            AddNode(node, 8);
            Console.WriteLine("Arbore initial: ");
            node.PrintPretty("", true);
            Console.WriteLine("PreOrdine");
            PreOrdine(node);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("PostOrdine");
            PostOrdine(node);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("InOrdine");
            InOrdine(node);
            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
        }
        private static void AddNode(Node node, int v)
        {
            if (v<=node.Value)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new Node(v);
                }
                else
                {
                    AddNode(node.LeftNode, v);
                }
            }
            else
            {
                if (node.RigthNode==null)
                {
                    node.RigthNode = new Node(v);
                }
                else
                {
                    AddNode(node.RigthNode, v);
                }
            }
        }
    }
}
