using System;

namespace HomeTask_6
{
    class Program
    {  
        static void Main(string[] args)
        {
            Graph graph = new Graph(); // Cоздаем экземпляр класса Graph, который, благодарая конструктору, сразу приобретате матирицу смежности.
            Console.WriteLine("BFS traveling:"); 
            graph.BFS();
            Console.WriteLine("\nDFS traveling:");
            graph.DFS();
            Console.Read(); 
        }

    }
}
