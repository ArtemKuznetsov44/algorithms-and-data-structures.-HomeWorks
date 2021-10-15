using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    // Данный класс служит для описание структуры одного элемента бинарного дерева.
    public class Node
    {
        public int Data { get; set; } // Значение элемента.
        public Node Left { get; set; } // Ссылка на левый элемент от текущего элемента.
        public Node Right { get; set; } // Ссылка на правый элемент от текущего элемента.
        public Node(int data) { Data = data; } // Конструктор с параметрами (значение для элемента).
    }
}
