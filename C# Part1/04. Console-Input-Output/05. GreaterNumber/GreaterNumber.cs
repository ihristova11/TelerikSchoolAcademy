using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}.", (firstNumber > secondNumber ? firstNumber : secondNumber));
    }
}

