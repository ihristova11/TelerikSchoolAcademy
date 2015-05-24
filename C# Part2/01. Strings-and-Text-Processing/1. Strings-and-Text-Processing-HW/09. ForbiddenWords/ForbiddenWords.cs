//We are given a string containing a list
//of forbidden words and a text containing
//some of these words. Write a program that
//replaces the forbidden words with asterisks. 
namespace _09.ForbiddenWords
{
    using System;
    using System.Text;
    class ForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbiddenWords = " Microsoft, CLR, PHP";
            char[] separators = { ',' };
            foreach (string word in forbiddenWords.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                text = text.Replace(word.Trim(), new string ('*',word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
