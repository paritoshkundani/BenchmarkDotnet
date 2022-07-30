// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkTests;

// to run from command line:
// Goto project folder:
// C:\temp\pluralsight\benchmarkDotNet\benchmarktests\BenchmarkTests
// run command to compile in Release mode
// dotnet build -c Release
// this will show you the .dll it built, copy full path and run below to execute dll
// dotnet C:\temp\pluralsight\benchmarkDotNet\benchmarktests\BenchmarkTests\bin\Release\net6.0\BenchmarkTests.dll

// Make sure to run in Release Mode

// 2 test, comment/uncomment the one to run
//BenchmarkRunner.Run<DateParserBenchmarks>()

BenchmarkRunner.Run<SecondDateParserBenchmarks>();