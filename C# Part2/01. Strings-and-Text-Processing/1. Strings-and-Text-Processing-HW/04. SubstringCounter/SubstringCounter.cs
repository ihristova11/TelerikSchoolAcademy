//Write a program that finds how many times
//a substring is contained in a given text 
//(perform case insensitive search).

namespace _04.SubstringCounter
{
    using System;
    using System.Text.RegularExpressions;
    class SubstringCounter
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searched = "in";
            text = text.ToLower();
            int counter = 0;
            int index = text.IndexOf(searched);
            while (index != -1)
            {
                index = text.IndexOf(searched, index + 1);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
