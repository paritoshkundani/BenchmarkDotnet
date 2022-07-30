using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTests
{
    // the class for all the benchmarks we are going to run

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        // UTC format so include Z at end
        private const string DateTime = "2022-07-30T14:38:00Z";

        // make sure it's initalized once so we can reuse the same instance across all tests
        private static readonly DateParser parser = new DateParser();

        [Benchmark]
        public void GetYearFromDateTime()
        {
            parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromDateSplit()
        {
            parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            parser.GetYearFromSpan(DateTime);
        }
    }
}
