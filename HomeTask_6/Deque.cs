using System;

namespace HomeTask_6
{
    // Данный класс реализует фукционал двухсторонней очереди - дека.
    class Deque<T> 
    {
        Element<T> Head; // Головной элемент.
        Element<T> Tail; // Хвост дека.
        int counter; 
        public void AddLast(T value) // Добавление элемента в конец списка. 
        {
            Element<T> tmp = new Element<T>(value);
            if (Head == null)
                Head = tmp;
            else
            {
                Tail.Next = tmp; // Делаем резервное место под следующее значение. 
                tmp.Prev = Tail; // Кидаем ссылка хвоста на предыдущий элемент перед добавленным
            }
            Tail = tmp; // Новый конец списка.
            counter++;
        } 

        public void AddFirst(T value) // Добавление элемента в начало списка.
        {
            Element<T> ourElement = new Element<T>(value);
            Element<T> tmp = Head;
            ourElement.Next = tmp;
            Head = ourElement;
            if (counter == 0)
                Tail = Head;
            else
                tmp.Prev = ourElement;
            counter++;
        } 

        public T RemoveFirst() // Удаление первого элемента.
        {
            if (counter == 0)
                throw new InvalidOperationException();
            T output = Head.Data;
            if (counter == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            counter--;
            return output;
        }
        public T RemoveLast() // Удаление последнего элемента.
        {
            if (counter == 0)
                throw new InvalidOperationException();
            T output = Tail.Data;
            if (counter == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }
            counter--;
            return output;
        }
        public int GetCount() // Получение кол-во элементов в списке. 
        {
            if (Head == null)
                return 0;
            else
            {
                Element<T> tmp = Head;
                int counter = 0;
                while (tmp != null)
                {
                    counter++;
                    tmp = tmp.Next;
                }
                return counter;
            }
        }
    }
}
