using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1
{
    // Класс служит лишь для отрисовки "разделителя" окна консоли.
    class LinePrinter
    {
        public static void Print()
        {
            string str = ""; 
            for(int i = 0; i < Console.WindowWidth; i++)
            {
                str += "="; 
            }
            Console.WriteLine(str);
            Console.WriteLine();  
        }
    }
}
