``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1237 (21H1/May2021Update)
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.201
  [Host]     : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
  DefaultJob : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT


```
|                         Method |      Mean |     Error |    StdDev | Rank | Allocated |
|------------------------------- |----------:|----------:|----------:|-----:|----------:|
|    PointDistanceFromClass_Sqrt | 0.9207 ns | 0.0325 ns | 0.0304 ns |    3 |         - |
| PointDistance_Structure_Sqrt_F | 0.9108 ns | 0.0325 ns | 0.0288 ns |    3 |         - |
| PointDistance_Structure_Sqrt_D | 0.7725 ns | 0.0262 ns | 0.0245 ns |    2 |         - |
|        PointDistance_Structure | 0.2316 ns | 0.0182 ns | 0.0152 ns |    1 |         - |
