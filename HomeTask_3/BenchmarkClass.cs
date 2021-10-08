using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace HomeTask_3
{
    [MemoryDiagnoser]
    [RankColumn]
    public class BenchmarkClass // Данный класс, служит для выполения тестов. 
    {
        // Создание необходимого для выполения тестов набора "данных". 
        // Модификатор readonly добавил по светам VS, но, на самом деле, плохо понимаю, действительно ли он здесь нужен ?

        readonly PointClass<float> pointFromClass_1 = new(3.14f, 2.12f);
        readonly PointClass<float> pointFromClass_2 = new(39.1f, 18.34f);
        readonly PointStruct<float> fpointFromSturct_1 = new(3.14f, 2.12f);
        readonly PointStruct<float> fpointFromSturct_2 = new(39.1f, 18.34f);
        readonly PointStruct<double> dpointFromSturct_1 = new(4.123, 5.218);
        readonly PointStruct<double> dpointFromSturct_2 = new(14.79, 27.84);

        [Benchmark]
        public float PointDistanceFromClass_Sqrt() // Работа с классом, тип значений float. Подсчет расстояние с ипользованием квадаратного корня.
        {
            float x = pointFromClass_2.x - pointFromClass_1.x;
            float y = pointFromClass_2.y - pointFromClass_1.y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public float PointDistance_Structure_Sqrt_F() // Работа со структурой, тип значений float. Подсчет расстояние с ипользованием квадаратного корня.
        {
            float x = fpointFromSturct_2.x - fpointFromSturct_1.x;
            float y = fpointFromSturct_2.y - fpointFromSturct_1.y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public double PointDistance_Structure_Sqrt_D() // Работа со структурой, тип значений double. Подсчет расстояние с ипользованием квадаратного корня.
        {
            double x = dpointFromSturct_2.x - dpointFromSturct_1.x;
            double y = dpointFromSturct_2.y - dpointFromSturct_1.y;
            return Math.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public float PointDistance_Structure() // Работа со структурой, тип значений float. Подсчет расстояние с ипользованием квадаратного корня.
        {
            float x = fpointFromSturct_2.x - fpointFromSturct_1.x;
            float y = fpointFromSturct_2.y - fpointFromSturct_1.y;
            return (x * x) + (y * y);
        }
    }
}
