using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_7
{
    // Данный класс предназначен для создания поля, а также работы с ним.
    class FieldMaker
    {
        int[,] field; // Двумерный массив для создания поля. 
        int rows; // Сохрание кол-во строк поля.
        int columns; // Сохранение кол-во колонок поля.
        public FieldMaker(int rows, int columns) // Конструктор с параметрами: кол-во строк, кол-во колонок.
        {
            field = new int[rows, columns]; // Создание поля.
            this.rows = rows;        // Сохранение 
            this.columns = columns;  // данных поля.
        }
        public void InitialFilling() // Начальное заполнение поля.
        {
            for (int i = 0; i < columns; i++) // Верхняя строка - единицами, так как существует лишь один путь.
            {
                field[0, i] = 1;
            }
            for (int i = 0; i < rows; i++) // Первый столбец - единицами, так как существует лишь один путь.
            {
                field[i, 0] = 1;
            }
        }

        public void GetCountOfWays() // Получние кол-во путей из начальной точки в конечную.
        {
            InitialFilling(); // Производим начальную инициализацию (заполнение).
            for (int i = 1; i < rows; i++) // Для прохода по строкам.
            {
                for (int j = 1; j < columns; j++) // Для прохода по колонкам.
                {
                    field[i, j] = field[i - 1, j] + field[i, j - 1]; // Вычисление кол-во путей для конкретной "точки".
                }
            } 
            Console.WriteLine($"Total count of ways: {field[rows - 1, columns - 1]}"); // Выводим результат на консоль.
        }

        public void PrintField() // Выод поля на консоль.
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(field[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
