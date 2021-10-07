using System;
using System.Collections.Generic;
namespace HomeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MakingChoice(); 
        }

        static void MakingChoice() 
        {
            ConsoleKeyInfo Choice; 
            do
            {
                Console.Clear(); 
                Console.WriteLine("Нажмите 1, чтобы начать работу со списком.");
                Console.WriteLine("Нажмите 2, чтобы начать работу с бинарыным поиском элемента.");
                Console.WriteLine("Для завершения работы нажмите Escape."); 
                Choice = Console.ReadKey();
                Console.WriteLine();
                switch (Choice.Key)
                {
                    case ConsoleKey.D1:
                        WorkWithDoublyLinkedNode.Start(); 
                        break;
                    case ConsoleKey.D2:
                        BinarySearhWorker.Start(); 
                        break;
                    default:
                        Console.WriteLine("Выбирите что-то из предложенного и нажмити соответствующую клавишу");
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.Read(); 
                        break; 
                }
            }
            while (Choice.Key != ConsoleKey.Escape) ;
        }
    }
}
