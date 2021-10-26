using System;

namespace HomeTask_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldMaker filed = new(3, 4); // Создание поля, по указанным пользователем размерам.
            filed.GetCountOfWays(); // Получение кол-во путей из начальной точки (левого верхнего угла поля),
                                    // в конечную (правый нижный угол поля).
            Console.WriteLine(); 
            filed.PrintField(); // Вывод созданного поля на экран консоли.
            Console.Read(); 
        }
    }
}
