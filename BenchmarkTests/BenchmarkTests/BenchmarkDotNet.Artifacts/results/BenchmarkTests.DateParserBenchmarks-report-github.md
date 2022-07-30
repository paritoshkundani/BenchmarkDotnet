``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1826 (21H1/May2021Update)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|               Method |      Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|--------------------- |----------:|----------:|----------:|-----:|-------:|----------:|
|      GetYearFromSpan |  26.42 ns |  0.740 ns |  2.169 ns |    1 |      - |         - |
| GetYearFromSubstring |  43.68 ns |  0.939 ns |  1.940 ns |    2 | 0.0102 |      32 B |
| GetYearFromDateSplit | 155.74 ns |  3.360 ns |  9.476 ns |    3 | 0.0508 |     160 B |
|  GetYearFromDateTime | 789.95 ns | 21.299 ns | 62.130 ns |    4 |      - |         - |
