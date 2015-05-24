//Write a program to check if in a given
//expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

namespace _03.AreBracketsCorrect
{
    using System;
    class AreBracketsCorrect
    {
        static void Main()
        {
            Console.Write("Enter some exprression:");
            string expression = Console.ReadLine();
            string openBracket = "(";
            string closeBracket = ")";
            int index = expression.IndexOf(openBracket);
            int index1 = expression.IndexOf(closeBracket);
            int counter = 0;
            while (index != -1)
            {
                counter++;
                index = expression.IndexOf(openBracket, index + 1);
            }
            if (counter >= 1)
            {
                while (index1 != -1)
                {
                    counter--;
                    index1 = expression.IndexOf(closeBracket, index1 + 1);
                }
                if (counter == 0)
                {
                    Console.WriteLine("Your expression is valid.");
                }
                else
                {
                    Console.WriteLine("Your expression is invalid.");
                }
            }
        }
    }
}
