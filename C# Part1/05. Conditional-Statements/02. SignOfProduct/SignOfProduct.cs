using System;

class SignOfProduct
{
    static void Main()
    {
        Console.Write("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        int counter = 0;
        if (firstNumber < 0)
        {
            counter++;
        }
        if (secondNumber < 0)
        {
            counter++;
        }
        if (thirdNumber < 0)
        {
            counter++;
        }
        if (counter % 2 == 0)
        {
            Console.WriteLine("The sign is +.");
        }
        else
        {
            Console.WriteLine("The sign is -.");
        }
    }
}

