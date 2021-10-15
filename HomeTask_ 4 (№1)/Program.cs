using System;
using System.Diagnostics;

namespace HomeTask__4___1_
{
    class Program
    {
        // После проведения нескольких тестов, можно убедиться, что использование хешей ускоряет выполнение оперции поиска элемента.
        static void Main(string[] args)
        {
            Preapring testingObject = new Preapring(); 
            testingObject.Zap(5); // Производим заполнение: массива, HeshSet, а также подстроки, поиск которой будет осуществляться (в парамертрах указана длинна этой строки).

            Stopwatch sw = new Stopwatch(); 
             
            sw.Start(); 
            TestForArray.Start(testingObject.array, testingObject.subString);
            sw.Stop();
            Console.WriteLine($"Время для массива: {sw.ElapsedMilliseconds}"); // Вывод результата после теста для массива. 

            sw.Restart(); 
            TestForHeshSet.Start(testingObject.hesh, testingObject.subString);
            sw.Stop();
            Console.WriteLine($"Время для HeshSet: {sw.ElapsedMilliseconds}"); // Вывод результата после теста для HeshSet.

            Console.Read(); 
        }
    }
}
