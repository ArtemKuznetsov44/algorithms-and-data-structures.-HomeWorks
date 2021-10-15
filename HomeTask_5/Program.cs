using System;

namespace HomeTask_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Create(); // Метод служит для заполнение дерева установленными заранее значениями. 
            binaryTree.BFS(17); // Поиск + пошаговый обход в ширину.
            Console.WriteLine(); 
            binaryTree.DFS(17); // Поиск + пошаговый обход в глубину.
            Console.Read(); 
        }
    }
}
