using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_2
{
    // Данный класс служит для формирование новой ячейки под элемент списка.
    class Element
    {
        public int Data { get; set; }
        public Element Next { get; set; }
        public Element Prev { get; set;  }
        public Element(int value)
        {
            Data = value; 
        }
        public Element() { }
    }
}
