//Write a program that reads a string
//from the console and prints all different
//letters in the string along with information 
//how many times each letter is found. 

namespace _21.CountDifferentLetters
{
    using System;
    class CountDifferentLetters
    {
        static void Main()
        {
            Console.Write("Enter some text:");
            string text = Console.ReadLine();
            char[] letters = new char[65536];
            for (int counter = 0; counter < text.Length; counter++)
            {
                if (char.IsLetter(text[counter]))
                {
                    letters[text[counter]]++;
                }
            }
            for (int count = 0; count < letters.Length; count++)
            {
                if (letters[count] > 0 && char.IsLetter((char)count))
                {
                    Console.WriteLine("{0} -> {1} times", (char)count, (int)letters[count]);
                }
            }
            Console.WriteLine();
        }
    }
}
