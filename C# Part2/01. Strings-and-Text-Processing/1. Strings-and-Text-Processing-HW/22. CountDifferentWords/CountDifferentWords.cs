//Write a program that reads a string from
//the console and lists all different words 
//in the string along with information how 
//many times each word is found.

namespace _22.CountDifferentWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class CountDifferentWords
    {
        static void Main()
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine(); 
            var dictionary = new Dictionary<string, int>();
            foreach (Match word in Regex.Matches(text, @"\w+"))
            dictionary[word.Value] = dictionary.ContainsKey(word.Value) ? dictionary[word.Value] + 1 : 1;
            foreach (var pair in dictionary)
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
        }
    }
}
