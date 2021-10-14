using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_4___2_
{
    public class Node
    {
        // Данный класс предназначен создания "структуры" элемета бинарного дерева.
        public int Data { get; set; } // Переменная с числовым значением элемента.
        public Node Left { get; set; } // Левый узел.
        public Node  Right { get; set; } // Правый узел.
        public Node(int data) // Конструктор с параметрами.
        {
            Data = data; 
        }
    }
}
