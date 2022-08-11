using System;

namespace PartialProgram
{
    public class Class1
    {
        public Node root;
        private static void PreOrder(Node node)
        {
            Console.Write($"{node.Value}, ");
            if (node.LeftNode != null)
            {
                PreOrder(node.LeftNode);
            }
            if (node.RigthNode != null)
            {
                PreOrder(node.RigthNode);
            }
        }
        private static void PostOrder(Node node)
        {
            if (node.LeftNode != null)
            {
                PostOrder(node.LeftNode);
            }
            if (node.RigthNode != null)
            {
                PostOrder(node.RigthNode);
            }
            Console.Write($"{node.Value}, ");
        }
        private static void InOrder(Node node)
        {
            if ((node.LeftNode == null) && (node.RigthNode == null))
            {
                Console.Write($"{node.Value}");
            }
            else
            {
                if (node.LeftNode != null)
                {
                    InOrder(node.LeftNode);
                }
                Console.Write($"{node.Value}, ");
                if (node.RigthNode != null)
                {
                    InOrder(node.RigthNode);
                }
            }
        }
        public void Print()
        {
            root.PrintPretty("", true);
        }
    }
}
