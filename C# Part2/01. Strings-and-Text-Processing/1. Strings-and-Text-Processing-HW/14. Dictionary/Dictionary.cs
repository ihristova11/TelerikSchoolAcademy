//A dictionary is stored as a sequence of text
//lines containing words and their explanations. 
//Write a program that enters a word and translates
//it by using the dictionary. 
namespace _14.Dictionary
{
    using System;
    using System.Collections.Generic;
    class Dictionary
    {
        static void Main()
        {
            string dictionary = ".Net - platform for applications from Microsoft\n"
                                 + "CLR - managed execution environment for .NET\n"
                                  + "namespace - hierarchical organization of classes\n";

            string[] words = dictionary.Split('\n', '-');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < words.Length - 1; i += 2)
            {
                if (word.Equals(words[i],StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("{0} -> {1}", word, words[i + 1]);
                    break;
                }
                else if (i == words.Length - 3)
                {
                    Console.WriteLine("There is no such word!\n");
                    Main();
                }
            }
            Console.WriteLine();
        }

    }
}
