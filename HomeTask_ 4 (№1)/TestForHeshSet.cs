using System.Collections.Generic;

namespace HomeTask__4___1_
{
    class TestForHeshSet
    {
        // Тестирование для HeshSet, эелменты которого благодаря хешам эквивалентны элементам созданного ранее массива строк.
        public static void Start(HashSet<int> hash, string substring)
        {
            foreach(int value in hash)
            {
                if(value.Equals(substring)) // Производим сравнение хеша и строки.
                {
                    break; // Остановка цикла в случее успешного поиска.
                }
            }
        }
    }
}
