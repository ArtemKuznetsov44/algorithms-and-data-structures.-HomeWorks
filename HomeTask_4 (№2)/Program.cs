using System;

namespace HomeTask_4___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.AddNode(6);
            tree.AddNode(2);
            tree.AddNode(11);
            tree.AddNode(3);
            tree.AddNode(9);
            tree.AddNode(30);
            tree.FindElement(3);
            Console.WriteLine("Ввод элементов бинарного дерева (корень-лево-право):");
            tree.Print_RD_L_R(); 
            Console.Read(); 


        }
    }
}
