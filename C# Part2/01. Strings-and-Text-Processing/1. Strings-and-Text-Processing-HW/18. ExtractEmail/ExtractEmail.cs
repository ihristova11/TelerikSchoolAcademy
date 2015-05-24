//Write a program for extracting all email addresses
//from given text. All substrings that match the format
//<identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractEmail
{
    using System;
    using System.Text.RegularExpressions;
    class ExtractEmail
    {
        static void Main()
        {
            Console.Write("Write some text containg an e-mail:");
            string text = Console.ReadLine();
            foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine("E-mail: {0}", item);
            }
        }
    }
}
