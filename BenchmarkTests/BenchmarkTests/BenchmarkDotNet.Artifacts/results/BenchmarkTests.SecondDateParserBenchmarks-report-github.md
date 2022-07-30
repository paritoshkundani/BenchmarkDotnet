``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1826 (21H1/May2021Update)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|                     Method |     Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|--------------------------- |---------:|---------:|---------:|-----:|-------:|----------:|
|      DateWithStringAndSpan | 48.94 ns | 0.358 ns | 0.299 ns |    1 |      - |         - |
| DateWithStringAndSubstring | 79.32 ns | 0.699 ns | 0.584 ns |    2 | 0.0305 |      96 B |
