namespace HomeTask_6
{
    // Данный класс служит для храние структуры одного элемента дека.
    class Element<T>
    {
        public T Data { get; set; } // Для занчения элемента.
        public Element<T> Prev { get; set; } // Ссылка на предыдущий элемент.
        public Element<T> Next { get; set; } // Ссылка на следующий элемент.
        public Element(T data) { Data = data;  }  // Конструктор с параметрами значения для элемента.
    }
}
