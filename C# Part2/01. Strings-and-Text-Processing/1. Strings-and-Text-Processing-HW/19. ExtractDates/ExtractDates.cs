//Write a program that extracts from a given 
//text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

namespace _19.ExtractDates
{
    using System;
    using System.Text.RegularExpressions;
    using System.Globalization;
    class ExtractDates
    {
        static void Main()
        {
            string format = "dd.MM.yyyy";
            Console.WriteLine("Enter some text containing dates: ");
            string text = Console.ReadLine();
            foreach (var item in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {
                string toString = Convert.ToString(item);
                DateTime date = DateTime.ParseExact(toString, format, CultureInfo.InvariantCulture);
                Console.WriteLine("Dates in Canada: {0}",date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
