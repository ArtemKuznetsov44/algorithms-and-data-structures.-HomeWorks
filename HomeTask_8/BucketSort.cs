using System;
using System.Collections.Generic;

namespace HomeTask_8
{
    // Данный класс реализует сортировку BucketSort, а также поддерживает вывод элементов массива на консоль.
    class BucketSort
    {
        // В данной реализации сортировка элементов, находящихся в корзине, производиться сортировкой вставками.
        public static int[] Start(int[] array) // Основа алгоритма BucketSort.
        {
            List<int> sortedArray = new(); // Лист для хранения отсортированного массива.

            int numOfBuckets = GetNumberOfBuckets(array); // Кол-во корзин, равное кол-ву элементов в списке.

            List<int>[] buckets = new List<int>[numOfBuckets]; // Создание списка, который будет хранить созданные далее корзины.

            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>(); // Каждый элемент списка корзин, хранит в себе еще один список. 

            for (int i = 0; i < array.Length; i++) // Проход по всем элементам переданного массива и распеределения их по корзинам.
            {
                int bucket = GetBucketIndex(array[i]); // Получение индекса корзины, в которую будет помещен элемент. 
                buckets[bucket].Add(array[i]); // Добавление элемента в козину.
            }
            for (int i = 0; i < numOfBuckets; i++) // Проход по всем корзинам.
            {
                List<int> temp = InsertionSort(buckets[i]); // Вызов сортировки для каждой из корзин.
                sortedArray.AddRange(temp); // Добавление уже отсортированной корзины в наш результирующий список.
            }
            return sortedArray.ToArray(); // Возвращаем готовый и отсортированный список элементов.
        }
        static List<int> InsertionSort(List<int> ourBucket)  // Реализации сортировки вставками.
        {
            for (int i = 0; i < ourBucket.Count - 1; i++) // Проход по всем элементам списка.
            {
                for (int j = i + 1; j > 0; j--) 
                {
                    if (ourBucket[j - 1] > ourBucket[j]) // Сравниваем предыдущий и следующий элемент списка.
                    {
                        // Если предыдущий элемент больше, то меняем их местами.
                        int temp = ourBucket[j - 1];
                        ourBucket[j - 1] = ourBucket[j];
                        ourBucket[j] = temp;
                    }
                }
            }
            return ourBucket;
        }
        public static void Print(int[] arr) // Вывод элементов массива на консоль.
        {
            foreach (int value in arr)
                Console.Write(value + " ");
            Console.WriteLine();
        }
        static int GetNumberOfBuckets(int[] arr) // Получение кол-во необходимых корзин.
        {
            int interval = 20; // Интервал значений для каждой из корзин.
            int numOfBuckets = GetMaxValue(arr) / interval;
            if (numOfBuckets % interval != 0)
                numOfBuckets++;
            return numOfBuckets; 
        }
        static int GetMaxValue(int[] arr) // Получение максимально элемента из массива.
        {
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }
            return maxValue; 
        }
        static int GetBucketIndex(int elementValue) // Получение индекса корзины, в которую следует поместить элемент.
        {
            int offSet = 20;
            bool flag = false;
            int indexOfBucket = 0; 
            while (!flag)
            {
                if (elementValue > offSet)
                {
                    offSet += 20;
                    indexOfBucket++; 
                }
                else 
                {
                    flag = true; 
                }
            }
            return indexOfBucket; 
        }
    }
}

