using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    // Данная структура служит для создания точки. Использовал обобщенность, так как тип данных изменчив.
    public class PointStruct<T>
    {
        public T x;
        public T y;
        public PointStruct(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
