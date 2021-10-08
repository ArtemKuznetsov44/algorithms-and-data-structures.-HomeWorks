using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_2
{
    // Данный класс служит для огранизации "интерактивной работы с двусвязным списком."
    class WorkWithDoublyLinkedNode
    {
        static void Sleaping()
        {
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.Read();
        } // Офрмление "продолжить".
        public static void Start()
        {
            int findingValue; // Сохранение значения для поиска.
            int newValue; // Сохранение значения для нового элемента.
            int index; // Сохранение индекса.
            DoublyLinkedNode OurNode = new(); 
            ConsoleKeyInfo G;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Добавление элемента в конец списка.");
                Console.WriteLine("2. Добавление элемента в начало списка.");
                Console.WriteLine("3. Добавление элемента после элемента, значение которого было передано.");
                Console.WriteLine("4. Добавление элемента после элемента, индекс которого был передан.");
                Console.WriteLine("5. Добавление элемента до элемента, заначение которого было передано.");
                Console.WriteLine("6. Добавление элемента до элемента, индекс которого был передан.");
                Console.WriteLine("7. Удаление элемента, значение которого было передано.");
                Console.WriteLine("8. Удаление элемента, индекс которого был предан.");
                Console.WriteLine("9. Показать элемент по указанному индеку.");
                Console.WriteLine("Х. Вывести все элементы списка.");
                G = Console.ReadKey();
                Console.WriteLine(); 
                try
                {
                    switch (G.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Write("Введите целочисленное число число для добавления в конец списка: ");
                            OurNode.AddLast(int.Parse(Console.ReadLine()));
                            Sleaping(); 
                            break;
                        case ConsoleKey.D2:
                            Console.Write("Введите целочисленное число число для добавление в начало списка: ");
                            OurNode.AddFirst(int.Parse(Console.ReadLine()));
                            Sleaping();
                            break;
                        case ConsoleKey.D3:
                            Console.Write("Введите значение элемента из списка, после которого будет добавлен новый элемент: ");
                            findingValue = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение для нового элемента: ");
                            newValue = int.Parse(Console.ReadLine());
                            OurNode.AddAfterByValue(findingValue, newValue);
                            Sleaping();
                            break;
                        case ConsoleKey.D4:
                            Console.Write("Введите индекс элемента из списка, после которого будет добавлен новый элемент: ");
                            index = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение для нового элемента: ");
                            newValue = int.Parse(Console.ReadLine());
                            OurNode.AddAfterByIndex(index, newValue);
                            Sleaping();
                            break;
                        case ConsoleKey.D5:
                            Console.Write("Введите значение элемента из списка, перед которым будет добавлен новый элемент: ");
                            findingValue = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение для нового элемента: ");
                            newValue = int.Parse(Console.ReadLine());
                            OurNode.AddBeforeByValue(findingValue, newValue);
                            Sleaping();
                            break;
                        case ConsoleKey.D6:
                            Console.Write("Введите индекс элемента из списка, перед которым будет добавлен новый элемент: ");
                            index = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение для нового элемента: ");
                            newValue = int.Parse(Console.ReadLine());
                            OurNode.AddBeforeByIndex(index, newValue);
                            Sleaping();
                            break;
                        case ConsoleKey.D7:
                            Console.Write("Введите значение элемента из списка для его удаления: ");
                            OurNode.RemoveByValue(int.Parse(Console.ReadLine()));
                            Sleaping();
                            break;
                        case ConsoleKey.D8:
                            Console.Write("Введите индекс элемента из списка для его удаления: ");
                            OurNode.RemoveByIndex(int.Parse(Console.ReadLine()));
                            Sleaping();
                            break;
                        case ConsoleKey.D9:
                            Console.Write("Введите индекс элемента из списка, который следует вывести на экран: ");
                            OurNode.GetElementByIndex(int.Parse(Console.ReadLine()));
                            Sleaping();
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Текущее состояние списка:");
                            OurNode.Print();
                            Sleaping();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
            }
            while (G.Key != ConsoleKey.Escape);
        }
    }
}
