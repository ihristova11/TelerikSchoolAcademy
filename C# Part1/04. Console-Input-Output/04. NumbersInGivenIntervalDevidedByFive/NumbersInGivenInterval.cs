using System;

class NumbersInGivenInterval
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        while (firstNumber <= secondNumber)
        {
            if (firstNumber % 5 == 0)
            {
                counter++;
            }
            firstNumber++;
        }
        Console.WriteLine("The numbers that can be divided by 5 without a reminder are:{0}", counter);
    }
}

