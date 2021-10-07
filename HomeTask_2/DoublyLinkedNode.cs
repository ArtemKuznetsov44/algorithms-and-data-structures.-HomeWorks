using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_2
{
    // Данный класс реализует меотоды по взаимодействию с двусвязным списком, которые унаследованы от интерфейса.
    // Сами "ячейки" для храниние элементов списка унаследованы от класса Element. 
    class DoublyLinkedNode : Element, IDoublyLinkedNode, IEnumerable<int>
    {
        Element Head; // Начальный элемента списка (глова). 
        Element Tail; // Завершающий элемент списка (хвост). 
        int counter; // Счетчик элементов. 

        public void AddLast(int value)
        {
            Element tmp = new Element(value);
            if (Head == null)
                Head = tmp;
            else
            {
                Tail.Next = tmp; // Делаем резервное место под следующее значение. 
                tmp.Prev = Tail; // Кидаем ссылка хвоста на предыдущий элемент перед добавленным
            }
            Tail = tmp; // Новый конец списка.
            counter++;
        } // Добавление элемента в конец списка. 

        public void AddFirst(int value)
        {
            Element ourElement = new Element(value);
            Element tmp = Head;
            ourElement.Next = tmp;
            Head = ourElement;
            if (counter == 0)
                Tail = Head;
            else
                tmp.Prev = ourElement;
            counter++;
        } // Добавление элемента в начало списка. 

        public void AddAfter(Element el, int value)
        {
            if (Head == null)
                AddFirst(value);
            if (el == Tail)
                AddLast(value);
            else
            {
                Element ourElement = new Element(value);
                ourElement.Next = el.Next;
                ourElement.Prev = el;
                el.Next = ourElement;
                counter++;
            }
        } // Добавление элемента после переданного элемента.

        public void AddAfterByValue(int findingElemet, int value)
        {
            if (Head == null)
                AddFirst(value);
            else if (findingElemet == Tail.Data)
                AddLast(value);
            else
            {
                Element currentElements = Head;
                while (currentElements.Data != findingElemet && currentElements != null)
                {
                    currentElements = currentElements.Next;
                }
                Element ourElement = new Element(value);
                ourElement.Next = currentElements.Next;
                ourElement.Prev = currentElements;
                currentElements.Next = ourElement;
                counter++;
            }
        } // Добавление элемента после элемента, значение котрого было передано.

        public void AddAfterByIndex(int index, int value)
        {
            if (index > GetCount() - 1 || index < 0)
                throw new Exception("Индекс выходит за пределы списка.");
            if (index == GetCount() - 1)
                AddLast(value);
            else
            {
                Element currentElement = Head;
                for (int i = 0; i < GetCount() - 1 && i != index; i++)
                {
                    currentElement = currentElement.Next;
                }
                Element ourElement = new Element(value);
                ourElement.Next = currentElement.Next;
                ourElement.Prev = currentElement;
                currentElement.Next = ourElement;
                counter++; 
            }

        } // Добавление элемента после элемента, идекс которого был передан.

        public void AddBefore(Element el, int value)
        {
            if (Head == null)
                AddFirst(value);
            else if (el == Head)
                AddFirst(value);
            else
            {
                AddAfter(el.Prev, value);
            }
        } // Добавление элемента до переданного элемента.

        public void AddBeforeByValue(int findingValue, int value)
        {
            if (Head == null)
                AddFirst(value);
            else
            {
                Element currentElement = Head;
                while (currentElement.Next.Data != findingValue && currentElement != null)
                {
                    currentElement = currentElement.Next;
                }
                AddAfter(currentElement, value);
            }
        } // Добавление элемента после элемента, значнение которого было передано. 

        public void AddBeforeByIndex(int index, int value)
        {
            if(index > GetCount() - 1 || index < 0)
                throw new Exception("Индекс выходит за пределы списка.");
            if (index == 0)
                AddFirst(value); 
            else
            {
                Element currentElement = Head; 
                for(int i = 0; i < GetCount() - 1 && i != index; i++)
                {
                    currentElement = currentElement.Next; 
                }
                AddAfter(currentElement.Prev, value); 
            }
        } // Добавление элемента до элемента, индекс которого был указан.

        public  void Remove(Element el) // Удаление переданного элемента. 
        {
            if (Head != null)
            {
                if (el == Head)
                {
                    Head = Head.Next;
                }
                else if (el == Tail)
                {
                    Tail = Tail.Prev;
                    Tail.Next = null;
                }
                else
                {
                    el.Prev.Next = el.Next;
                }
                counter--;
            }
        }

        public void RemoveByValue(int valueForDelete) // Удаление элемента по переданному значению. 
        {
            if (Head != null)
            {
                Element currentElement = Head;
                while (currentElement.Data != valueForDelete && currentElement != null)
                {
                    currentElement = currentElement.Next;
                }
                Remove(currentElement);
            }
        }

        public void RemoveByIndex(int index) //Удаление элемента по переданному индексу. 
        {
            if (index > GetCount() - 1 || index < 0)
                throw new Exception("Идекс выходит за пределы списка.");
            if (index == 0)
                Head = Head.Next;
            else if (index == GetCount() - 1)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }
            else
            {
                Element tmp = Head;
                for (int i = 0; i < GetCount() - 1 && i != index; i++)
                {
                    tmp = tmp.Next;
                }
                Remove(tmp);
            }
        }

        public Element Finding(int findingValue) // Поиск нужного элемента, по его значению.
        {
            if (GetCount() == 0)
                throw new Exception("Список пуст."); 
            if (findingValue == Head.Data)
                return Head;
            else if (findingValue == Tail.Data)
                return Tail; 
            else
            {
                Element currentElement = Head; 
                while(currentElement.Data != findingValue)
                {
                    if (currentElement.Next == null)
                        throw new Exception("Такого элемента нет в списке."); 
                    else 
                        currentElement = currentElement.Next; 
                }
                return currentElement; 
            }
        }

        public int GetElementByIndex(int index) 
        {
            if (index > GetCount() - 1 || index < 0)
                throw new Exception("Индекс находиться за пределами списка");
            else if (index == 0)
                return Head.Data;
            else if (index == GetCount() - 1)
                return Tail.Data;
            else
            {
                Element tmp = Head; 
                for(int i = 0; i < GetCount() - 1 && i != index; i++)
                {
                    tmp = tmp.Next; 
                }
                return tmp.Data; 
            }
        }  // Показать элемент по указанному индексу.
        public int GetCount() // Получение кол-во элементов в списке. 
        {
            if (Head == null)
                return 0;
            else
            {
                Element tmp = Head;
                int counter = 0;
                while (tmp != null)
                {
                    counter++;
                    tmp = tmp.Next;
                }
                return counter;
            }
        }

        public int Count { get { return GetCount(); } }// Кол-во элементов в списке. 

        public void Print() // Вывод элементов на консоль в строку. 
        {
            if (Head != null)
            {
                string str = String.Empty;
                Element tmp = Head;
                while (tmp != null)
                {
                    str += tmp.Data + (tmp.Next == null ? "" : " ");
                    tmp = tmp.Next;
                }
                Console.WriteLine(str);
            }
            else
                Console.WriteLine("Список пуст.");
        }

        #region // Реализация интрефейса IEnumerable<int>
        public IEnumerator<int> GetEnumerator()
        {
            Element tmp = Head;
            while (tmp != null)
            {
                yield return tmp.Data;
                tmp = tmp.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
