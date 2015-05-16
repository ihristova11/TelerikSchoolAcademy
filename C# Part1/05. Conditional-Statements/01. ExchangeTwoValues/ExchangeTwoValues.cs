using System;

class ExchangeTwoValues
{
    static void Main()
    {
        Console.Write("Enter first value:");
        int firstVariable = int.Parse(Console.ReadLine());
        Console.Write("Enter second value:");
        int secondVariable = int.Parse(Console.ReadLine());
        int thirdVariable;
        if (firstVariable > secondVariable)
        {
            thirdVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = thirdVariable;
            Console.WriteLine("First value:{0}", firstVariable);
            Console.WriteLine("Second value:{0}", secondVariable);
        }
        else
        {
            Console.WriteLine("The first value isn't greater than the second.");
        }

    }
}

