using System;

namespace HomeTask_1
{
    // Данный класс служит для формирование тестового кейса для проверки того или иного задания. 
    class TestCase<T> // Использовал обобщение, так как ожидаемый результат, в зависимости от задания, принимает разный тип данных. 
    {
        public int value { get; set; }
        public T Expected { get; set; }
        public Exception ExpectedException { get; set; }

    }
}
