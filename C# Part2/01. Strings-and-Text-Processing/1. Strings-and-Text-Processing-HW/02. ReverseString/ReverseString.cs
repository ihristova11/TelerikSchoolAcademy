//Write a program that reads a string,
//reverses it and prints the result at the console.

namespace _02.ReverseString
{
    using System;
    using System.Text;
    class ReverseString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
        }
        public static string ReverseText (string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int counter = text.Length - 1; counter >= 0; counter--)
            {
                sb.Append(text[counter]);
            }
            return sb.ToString();
        }
    }
}
