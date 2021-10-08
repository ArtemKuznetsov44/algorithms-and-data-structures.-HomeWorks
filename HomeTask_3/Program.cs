using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HomeTask_3
{
    class Program
    {
        // Огромная просьба указать на какие-либо недочеты в работе. Заранее спасибо !
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>(); 
        }
    }
}
