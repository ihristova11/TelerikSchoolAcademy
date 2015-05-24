//Write a program that reads two dates in
//the format: day.month.year and calculates
//the number of days between them. 
namespace _16.DaysBetweenDates
{
    using System;
    using System.Globalization;
    class DaysBetweenDates
    {
        static void Main()
        {
            string format = "d.MM.yyyy";
            Console.Write("Enter the first date in format - d.MM.yyyy:");
            string firstDate = Console.ReadLine();
            DateTime first = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
            Console.Write("Enter the second date in format - d.MM.yyyy:");
            string secondDate = Console.ReadLine();
            DateTime second = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Distance:{0} days",(second - first).TotalDays);
        }
    }
}
