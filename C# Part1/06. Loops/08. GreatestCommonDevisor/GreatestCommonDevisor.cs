//Write a program that calculates the greatest common divisor (GCD) of
//given two numbers. Use the Euclidean algorithm (find it in Internet).using System;

class GreatestCommonDevisor
{
    static void Main()
    {
        int gcd, temp;
        Console.Write("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber == 0 && secondNumber > 0)
        {
            gcd = secondNumber;
        }
        else if (secondNumber == 0 && firstNumber > 0)
        {
            gcd = firstNumber;
        }
        else if (firstNumber > 0 && secondNumber > 0)
        {
            while (secondNumber > 0)
            {
                temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            gcd = firstNumber;
            Console.WriteLine("The GCD is {0}.", gcd);
        }
    }
}

