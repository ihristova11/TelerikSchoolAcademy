using System;

class TheBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        int thirdNum = int.Parse(Console.ReadLine());
        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The first number is the biggest.");
            }
            else
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }
        else
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("The second number is the biggest.");
            }
            else
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }
    }
}

