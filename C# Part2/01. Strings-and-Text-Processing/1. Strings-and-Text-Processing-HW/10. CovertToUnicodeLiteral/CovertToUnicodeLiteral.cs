//Write a program that converts a
//string to a sequence of C# Unicode 
//character literals. Use format strings. 
namespace _10.CovertToUnicodeLiteral
{
    using System;
    using System.Text;
    class CovertToUnicodeLiteral
    {
        static void Main()
        {
            string template = "\\u{0:X4}";
            string text = Console.ReadLine();
            StringBuilder converted = new StringBuilder();
            foreach (char item in text)
            {
                converted.Append(string.Format(template, (int)item));
            }
            Console.WriteLine(converted.ToString());
        }
    }
}
