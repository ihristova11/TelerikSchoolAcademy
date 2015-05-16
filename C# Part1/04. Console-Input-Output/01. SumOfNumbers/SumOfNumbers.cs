using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three numbers is {0}.", firstNumber + secondNumber + thirdNumber);
    }
}

