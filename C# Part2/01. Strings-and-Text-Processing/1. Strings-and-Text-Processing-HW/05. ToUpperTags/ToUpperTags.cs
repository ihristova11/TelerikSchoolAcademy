//You are given a text. Write a program that changes
//the text in all regions surrounded by the tags <upcase>
//and </upcase> to uppercase. The tags cannot be nested. 
namespace _05.ToUpperTags
{
    using System;
    using System.Text.RegularExpressions;
    class ToUpperTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            text = text.ToLower();
            string replaced = Regex.Replace(text, "<upcase>(.*?)</upcase>", a => a.Groups[1].Value.ToUpper());
            Console.WriteLine(replaced);
        }
    }
}
