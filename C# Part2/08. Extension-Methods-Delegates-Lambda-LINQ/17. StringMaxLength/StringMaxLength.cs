//Write a program to return the string with 
//maximum length from an array of strings. Use LINQ.

namespace _17.StringMaxLength
{
    using System;
    using System.Linq;
    class StringMaxLength
    {
        static void Main()
        {
            string[] strings = new string[]
            {
                "Bai Ivan", "something","went","number" 
            };

            var maxStringLength = strings.OrderByDescending(someString => someString.Length).First();
            Console.WriteLine(maxStringLength);
        }
    }
}
