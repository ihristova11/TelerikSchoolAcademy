//Write a program that reverses the words in given sentence.

namespace _13.ReverseWordsInSentence
{
    using System;
using System.Collections.Generic;
using System.Text;
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
 
            char[] separators = new char[] {' ', ',', '!', '?', '.' };
            List<string> words = new List<string>(text.Split(separators, StringSplitOptions.RemoveEmptyEntries));
 
            for (int i = words.Count - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
 
                if (words[i] == "PHP")
                {
                    Console.Write(",");
                }
            }
            Console.Write("!");
            Console.WriteLine();
        }
    
    }
}
