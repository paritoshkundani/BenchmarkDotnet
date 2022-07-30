using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTests
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SecondDateParserBenchmarks
    {
        // another set to tests
        private const string _dateAsText = "07 30 2022";

        // make sure it's initalized once so we can reuse the same instance across all tests
        private static readonly DateParser parser = new DateParser();

        [Benchmark]
        public void DateWithStringAndSubstring()
        {
            parser.DateWithStringAndSubstring(_dateAsText);
        }

        [Benchmark]
        public void DateWithStringAndSpan()
        {
            parser.DateWithStringAndSpan(_dateAsText);
        }
    }
}
