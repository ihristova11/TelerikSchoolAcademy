using System;

class IntegerDevidedByFiveAndSeven
{
    static void Main()
    {
        bool isTrue;
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 35 == 0)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
        Console.WriteLine(isTrue);
    }
}

