//Write a program that extracts from a
//given text all sentences containing given word.

namespace _08.ExtractSentence
{
    using System;
    class ExtractSentence
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searched = " in ";
            char separator = '.';
            int index;
            string[] sentencesArray = text.Split(separator);
            for (int i = 0; i < sentencesArray.Length; i++)
            {
                index = sentencesArray[i].IndexOf(searched);
                if (index != -1)
                {
                    Console.WriteLine(sentencesArray[i] + ".");
                }
            }
        }
    }
}
