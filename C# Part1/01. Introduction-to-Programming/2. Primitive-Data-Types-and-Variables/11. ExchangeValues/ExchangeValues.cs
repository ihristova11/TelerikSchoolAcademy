using System;

class ExchangeValues
{
    static void Main()
    {
        int firstVariable = 10;
        int secondVariable = 5;
        int thirdVariable = firstVariable;
        Console.WriteLine(firstVariable + " " + secondVariable);
        firstVariable = secondVariable;
        secondVariable = thirdVariable;
        Console.WriteLine(firstVariable + " " + secondVariable);

    }
}

