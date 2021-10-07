using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1
{
    class TestStarter2
    {
        public static void StartTest2(TestCase<int> tc_6, TestCase<int> tc_7, TestCase<int> tc_8, TestCase<int> tc_9, TestCase<int> tc_10)
        {
            Console.WriteLine("Задание №2. Фибоначи. Тест - 1");
            Testing_Task2(tc_6);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Тест - 2");
            Testing_Task2(tc_7);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Тест - 3");
            Testing_Task2(tc_8);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Тест - 4");
            Testing_Task2(tc_9);
            Console.WriteLine();

            Console.WriteLine("Задание №2. Фибоначи. Тест - 5");
            Testing_Task2(tc_10);
            Console.WriteLine();
        }
        static void Testing_Task2(TestCase<int> testCase)
        {
            try
            {
                int result = Fib(testCase.value);
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
        static int Fib(int n) // Без использования рекурсии.
        {
            if (n < 0)
                throw new ArgumentException("Позиция в последовательности Фибоначи не может обозначаться отрицательным числом");
            int prev = 0;
            int next = 1;
            int tmp;
            for (int i = 0; i < n; i++)
            {
                tmp = prev;
                prev = next;
                next += tmp;
            }
            return prev;
        }
    }
}
