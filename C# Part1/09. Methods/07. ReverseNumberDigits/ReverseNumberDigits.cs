//Write a method that reverses the digits of given decimal number.
//Example: 256 -> 652

using System;

class ReverseNumberDigits
{
    public static int ReverseNumber(int number)
    {
        int newNumber = 0;
        while (number > 0)
        {
            newNumber = (newNumber * 10) + (number % 10);
            number /= 10;
        }
        return newNumber;
    }
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The new number is {0}.",ReverseNumber(number));
    }
}

