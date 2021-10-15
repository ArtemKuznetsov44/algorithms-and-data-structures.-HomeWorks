using System;
using System.Collections.Generic;


namespace HomeTask__4___1_
{
    class Preapring
    {
        public string[] array = new string[1000000]; // Создание массива длинны 1000.000.
        public HashSet<int> hesh = new HashSet<int>(); // Длина HeshSet будет +- такой же, как и у массива.
        Random rnd = new Random(); // Для генерации случайных чисел.
        public string subString; 
        public void Zap(int lenght) // Метод производит заполение нашего массива и HeshSet униниклбными стороками, а в HeshSet вместо смамой строки помещается ее хеш.
        {
            for (int i = 0; i < array.Length; i++)
            {
                string element = Generator(lenght);
                array[i] = element; // Добавление строки в массив. 
                hesh.Add(element.GetHashCode()); // Добалвение элемента в HeshSet путем вязтия хеша от сгенерированной строки.
            }
            subString = Generator(lenght); 
        }
        public string Generator(int lenght) // Метод генерирует случаные строки указанной длины.
        {
            string substring = String.Empty;
            for (int i = 0; i < lenght; i++)
            {
                char elemnt = (char)rnd.Next('a', 'z');
                substring += elemnt; 
            }
            return substring; 
        }

    }
}
