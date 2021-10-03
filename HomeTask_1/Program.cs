using System;

namespace HomeTask_1
{
    // Задание №2. 
    // Асимптотическая сложность представленного алгоритма равна O(n^3), так как присутствует тройная вложенность цикла. 

    class Program
    {
        // Из-за этих тестовых кэйсов, кода получился довольно громоздким (((
        // Буду рад услышать совет, как можно было бы сократить код. Заранее спасибо !
        static void Main(string[] args)
        {
            TestCase<string> testCase_1 = new TestCase<string>
            {
                value = 5,
                Expected = "Простое",
                ExpectedException = null
            };
            TestCase<string> testCase_2 = new TestCase<string>
            {
                value = 77,
                Expected = "Не простое",
                ExpectedException = null
            };
            TestCase<string> testCase_3 = new TestCase<string>
            {
                value = -2,
                ExpectedException = new ArgumentException("Число должно быть положительным.")
            };
            TestCase<string> testCase_4 = new TestCase<string>
            {
                value = 199,
                Expected = "Простое",
                ExpectedException = null
            };
            TestCase<string> testCase_5 = new TestCase<string>
            {
                value = -2,
                ExpectedException = new ArgumentException("Число должно быть положительным.")
            };
            TestCase<int> testCase_6 = new TestCase<int>
            {
                value = 7,
                Expected = 13,
                ExpectedException = null
            };
            TestCase<int> testCase_7 = new TestCase<int>
            {
                value = 10,
                Expected = 55,
                ExpectedException = null
            };
            TestCase<int> testCase_8 = new TestCase<int>
            {
                value = 14,
                Expected = 377,
                ExpectedException = null
            };
            TestCase<int> testCase_9 = new TestCase<int>
            {
                value = -8,
                ExpectedException = new Exception("Позиция в последовательности Фибоначи не может обозначаться отрицательным числом")
            };
            TestCase<int> testCase_10 = new TestCase<int>
            {
                value = -99,
                ExpectedException = new Exception("Позиция в последовательности Фибоначи не может обозначаться отрицательным числом")
            };
            LinePrinter.Print();
            TestStarter1.StartingTask_1(testCase_1, testCase_2, testCase_3, testCase_4, testCase_5); // Запуск тестов к заданию №1.
            LinePrinter.Print();
            TestStarter2_Recursion.StartTest2_Recursion(testCase_6, testCase_7, testCase_8, testCase_9, testCase_10); // Запуск тестов к заданию №2(РЕКУРСИЯ). 
            LinePrinter.Print();
            TestStarter2.StartTest2(testCase_6, testCase_7, testCase_8, testCase_9, testCase_10); // Запуск тестов к заданию №2. 
            LinePrinter.Print(); 
        }

    }
}
    
