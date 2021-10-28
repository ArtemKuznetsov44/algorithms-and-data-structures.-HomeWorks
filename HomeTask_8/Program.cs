using System;

namespace HomeTask_8
{
    class Program
    {
        static void Main()
        { 
            int[] array = new int[] { 28, 84, 18, 10, 92, 8, 54, 8, 81, 64, 21, 81}; // Пример массива из методички.
            Console.WriteLine("Массив до сортировки: "); 
            BucketSort.Print(array); // Вывод всех элементов массива на консоль.
            int[] sortedArray = BucketSort.Start(array); // Вызываем нашу сортировку, которая возвращает новый отсортированный массив.
            Console.WriteLine("\nМассив после сортировки: ");
            BucketSort.Print(sortedArray); // Вывод всех элементов отсортированного массива.
            Console.Read(); 
        }
    }
}
