//Write a program that reads from the
//console a string of maximum 20 characters. 
//If the length of the string is less than 20,
//the rest of the characters should be filled with '*'.
//Print the result string into the console.

namespace _06.FillString
{
    using System;
    using System.Text;
    class FillString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var stringBuilder = new StringBuilder(text);
            int length = text.Length;
            if (length < 20)
            {
                for (int count = 1; count <= 20 - length; count++)
                {
                    stringBuilder.Append('*');
                }
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
