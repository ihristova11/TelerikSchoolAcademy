//Write a program that creates an array containing all
//letters from the alphabet (A-Z). Read a word from the console and 
//print the index of each of its letters in the array.

using System;

class LettersOfEnglishAlphabet
{
    static void Main()
    {
        char[] Array = new char[26];
        for (int i = 0; i <= 25; i++)
        {
            Array[i] = (char)(65 + i);
        }
        string word;
        Console.Write("Enter word: ");
        word = Console.ReadLine().ToUpper();
        foreach (char letter in word)
        {
            for (int j = 0; j <= Array.Length - 1; j++)
            {
                if (letter == Array[j])
                {
                    Console.WriteLine("The index of '{0}' in the array is {1}.", Array[j], j);
                }
            }
        }
    }
}

