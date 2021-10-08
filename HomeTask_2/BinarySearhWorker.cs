using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_2
{
    // Данный класс служит для работы и с бинарным поискоим, а также для подсчета его асимптотической сложности.
    class BinarySearhWorker
    {
        static (int element, int N) BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            int N = 0;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                N++; 
                if (searchValue == inputArray[mid])
                {
                    return (inputArray[mid], N);
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return (-1, N);
        } // Алгорит бинарного поиска и одновременный посчет кол-во выполненный делений.
        public static void Start() 
        {
            try
            {
                Console.Write("Введите размерность для массива, который будет заполен случайными числами: ");
                int[] ourArray = Zap(int.Parse(Console.ReadLine()));
                Console.WriteLine("Созданный массив:");
                PrintArray(ourArray);
                Console.WriteLine("Отсортированный масиив:");
                Array.Sort(ourArray);
                PrintArray(ourArray);
                Console.Write("Введите значение для поиска: ");
                var result = BinarySearch(ourArray, int.Parse(Console.ReadLine()));
                Console.WriteLine($"Наш элемент {result.element}. Асимптотическая сложность равна {Math.Log(result.N)}");
                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } // Точка старта. 

        static int[] Zap(int size)
        {
            int[] array = new int[size]; 
            Random rnd = new Random(); 
            for(int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 200); 
            }
            return array; 
        } // Заполнение массива случайными числами в установленном диапазоне.

        static void PrintArray(int[] arr)
        {
            foreach(int value in arr)
            {
                Console.Write(value + " "); 
            }
            Console.WriteLine(); 
        } // Вывод всех элементов массива. 
    } 
}
