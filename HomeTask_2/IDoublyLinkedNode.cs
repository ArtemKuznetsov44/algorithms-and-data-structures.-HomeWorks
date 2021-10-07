using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_2
{
    // Интерфейс с методами для класса DoublyLinkedNode.
    interface IDoublyLinkedNode
    {
        int Count { get; }
        void AddLast (int value);
        void AddFirst(int value);
        void AddAfter(Element element,int value);
        void AddAfterByValue(int findingValue, int value);
        void AddBefore(Element element, int value);
        void AddBeforeByValue(int findingValue, int value); 
        void Remove(Element element);
        void RemoveByValue(int valueForDelete); 
        void RemoveByIndex(int index);
        int GetElementByIndex(int index); 
        Element Finding(int findingValue); 
    }
}
