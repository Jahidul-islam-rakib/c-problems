using System;

public class MonthShow
{
    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    };
    
    public static void Main(string[] args)
    {
        Console.WriteLine("All month name of English year : -->");

        foreach(Month MonthName in Enum.GetValues(typeof(Month)))
        {

            Console.WriteLine("{0} : {1} ", MonthName,(int)MonthName);
        }
    }

}