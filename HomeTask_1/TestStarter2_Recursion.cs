using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1
{
    // Данный класс служит для запуска тестов по последовательности Фибоначи с использованием рекурсии.
    class TestStarter2_Recursion
    {
        // Вызов тестирования и "читаемый вывод". 
        public static void  StartTest2_Recursion(TestCase<int> tc_6, TestCase<int> tc_7, TestCase<int> tc_8, TestCase<int> tc_9, TestCase<int> tc_10)
        {
            Console.WriteLine("Задание №2. Фибоначи. Рекурсия. Тест - 1");
            Testing_Task2(tc_6);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Рекурсия. Тест - 2");
            Testing_Task2(tc_7);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Рекурсия. Тест - 3");
            Testing_Task2(tc_8);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Рекурсия. Тест - 4");
            Testing_Task2(tc_9);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Рекурсия. Тест - 5");
            Testing_Task2(tc_10);
            Console.WriteLine();
        }

        static void Testing_Task2(TestCase<int> testCase) // Сам тест.
        {
            try
            {
                int result = RecFib(testCase.value);
                if (result == testCase.Expected)
                    Console.WriteLine("---Тесть успешен---");
                else
                    Console.WriteLine("---Тесть неуспешен---");
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                    Console.WriteLine(testCase.ExpectedException.Message);
                else
                    Console.WriteLine("---Тесть неуспешен---");
            }
        }
        static int RecFib(int value) // Функция для вичисления чисел Фибоначи с ипользованием рекурсии. 
        {
            if (value < 0)
                throw new ArgumentException("Позиция в последовательности Фибоначи не может обозначаться отрицательным числом");
            if (value == 0 || value == 1)
                return value;
            else
                return RecFib(value - 1) + RecFib(value - 2);
        }
    }
}
