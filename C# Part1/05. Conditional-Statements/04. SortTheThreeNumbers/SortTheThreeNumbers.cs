using System;

class SortTheThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggerNumber;
        double biggestNumber;
        double bigNumber;
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                biggestNumber = firstNumber;
                if (secondNumber < thirdNumber)
                {
                    biggerNumber = thirdNumber;
                    bigNumber = secondNumber;
                }
                else
                {
                    biggerNumber = secondNumber;
                    bigNumber = thirdNumber;
                }
            }
            else
            {
                biggestNumber = thirdNumber;
                biggerNumber = firstNumber;
                bigNumber = secondNumber;
            }
        }
        else
        {
            biggestNumber = secondNumber;
            if (secondNumber < thirdNumber)
            {
                biggestNumber = thirdNumber;
                biggerNumber = secondNumber;
                bigNumber = firstNumber;
            }
            else
            {
                if (thirdNumber < firstNumber)
                {
                    biggerNumber = firstNumber;
                    bigNumber = thirdNumber;
                }
                else
                {
                    biggerNumber = thirdNumber;
                    bigNumber = firstNumber;
                }
            }
        }
        Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", biggestNumber, biggerNumber, bigNumber );
    }
}

