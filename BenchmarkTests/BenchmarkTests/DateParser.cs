using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTests;

// get year from date, which is string, as int
public class DateParser
{
    public int GetYearFromDateTime(string dateTimeAsString)
    {
        DateTime dateTime = DateTime.Parse(dateTimeAsString);
        return dateTime.Year;
    }

    public int GetYearFromSplit(string dateTimeAsString)
    {
        var splitOnHypen = dateTimeAsString.Split('-');
        return int.Parse(splitOnHypen[0]);
    }

    public int GetYearFromSubstring(string dateTimeAsString)
    {
        var indexOfHypen = dateTimeAsString.IndexOf('-');
        return int.Parse(dateTimeAsString.Substring(0, indexOfHypen));
    }

    public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHypen = dateTimeAsSpan.IndexOf('-');
        return int.Parse(dateTimeAsSpan.Slice(0, indexOfHypen));
    }

    // below all for SecondDateParserBenchmark tests
    public (int day, int month, int year) DateWithStringAndSubstring(string dateAsText)
    {
        var dayAsText = dateAsText.Substring(0, 2);
        var monthAsText = dateAsText.Substring(3, 2);
        var yearAsText = dateAsText.Substring(6);

        var day = int.Parse(dayAsText);
        var month = int.Parse(monthAsText);
        var year = int.Parse(yearAsText);

        return (day, month, year);
    }

    public (int day, int month, int year) DateWithStringAndSpan(string dateAsText)
    {
        ReadOnlySpan<char> dateAsSpan = dateAsText;
        var dayAsText = dateAsSpan.Slice(0, 2);
        var monthAsText = dateAsSpan.Slice(3, 2);
        var yearAsText = dateAsSpan.Slice(6);

        var day = int.Parse(dayAsText);
        var month = int.Parse(monthAsText);
        var year = int.Parse(yearAsText);

        return (day, month, year);
    }
}
