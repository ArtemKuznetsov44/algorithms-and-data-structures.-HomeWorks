using System;

namespace HomeTask_4___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node node = new Node(6); 
            tree.AddNode(6);
            tree.AddNode(2);
            tree.AddNode(11);
            tree.AddNode(3);
            tree.AddNode(9);
            tree.AddNode(30);
            tree.PrintLKP();
            Console.Read(); 


        }
    }
}
