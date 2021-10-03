using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1
{
    // Данный класс служит для запуска тестов по проверке числа на простоту.
    class TestStarter1
    {
        // Вызов тестов и "читаемый вывод". 
        public static void StartingTask_1(TestCase<string> tc_1, TestCase<string> tc_2, TestCase<string> tc_3, TestCase<string> tc_4, TestCase<string> tc_5)
        {
            Console.WriteLine("Задание №1. Тест - 1.");
            Testing_Task1(tc_1);
            Console.WriteLine();

            Console.WriteLine("Задание №1. Тест - 2.");
            Testing_Task1(tc_2);
            Console.WriteLine();

            Console.WriteLine("Задание №1. Тест - 3");
            Testing_Task1(tc_3);
            Console.WriteLine();

            Console.WriteLine("Задание №1. Тест - 4");
            Testing_Task1(tc_4);
            Console.WriteLine();

            Console.WriteLine("Задание №1. Тест - 5");
            Testing_Task1(tc_5);
            Console.WriteLine();
        }
        static void Testing_Task1(TestCase<string> testCase) // Сам тест. 
        {
            try
            {
                string result = IsNumberEven(testCase.value);
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
        static string IsNumberEven(int number) // Проверка числа на простоту. Код с блок-схемы в задании.
        {
            if (number < 0)
                throw new Exception();

            int d = 0, i = 2;
            while (i < number)
            {
                if (number % i == 0)
                    d++;
                i++;
            }
            if (d == 0)
                return "Простое";
            else
                return "Не простое";
        }
    }
}
