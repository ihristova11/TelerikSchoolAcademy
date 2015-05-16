using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        decimal firstNumber = 5.00000001m;
        decimal secondNumber = 5.00000003m;
        Console.WriteLine(secondNumber - firstNumber);
    }
}

