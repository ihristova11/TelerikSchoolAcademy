//Write a program that reads a list of words,
//separated by spaces and prints the list
//in an alphabetical order.

namespace _24.WordsInAlphabeticalOrder
{
    using System;
    using System.Collections.Generic;
    class WordsInAlphabeticalOrder
    {
        static void Main()
        {
            Console.Write("Enter words separated by space: ");
            string words = Console.ReadLine();
            char separator = ' ';
            List<string> list = new List<string>(words.Split(separator));
            list.Sort();
            for (int counter = 0; counter < list.Count; counter++)
            {
                Console.WriteLine(list[counter]);
            }
        }
    }
}
