//Write a program that extracts from 
//a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20.ExtractPalindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class ExtractPalindromes
    {
        static string ReverseText(string text)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed.Append(text[i]);
            }

            return reversed.ToString();
        }
        static void Main()
        {
            Console.Write("Enter some text containing palindromes: ");
            string text = Console.ReadLine();
            List<string> list = new List<string>(text.Split(' '));

            for (int i = 0; i < list.Count; i++)
            {
                string word = ReverseText(list[i]);

                if (list[i] == word)
                {
                    Console.WriteLine("Palindromes are: {0}",word);
                }
            }
            
            
        }
    }
}
