//Write a program that reads a string 
//from the console and replaces all series
//of consecutive identical letters with a single one. 
namespace _23.ConsecutiveIdenticalLetters
{
    using System;
    using System.Text;
    class ConsecutiveIdenticalLetters
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string text = Console.ReadLine();
            StringBuilder newString = new StringBuilder();
            char letter = text[0];
            for (int i = 1; i < text.Length; i++)
            {
                char nextLetter = text[i];
                if (letter != nextLetter)
                {
                    newString.Append(letter);
                    letter = nextLetter;
                }
                if (i == text.Length - 1)
                {
                    newString.Append(nextLetter);
                }
            }
            Console.WriteLine(newString);
        }
    }
}
