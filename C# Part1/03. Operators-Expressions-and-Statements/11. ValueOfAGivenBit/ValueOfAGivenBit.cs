using System;

class ValueOfAGivenBit
{
    static void Main()
    {
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Position of the bit:");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int numberAndMask = mask & number;
        if (numberAndMask == 0)
        {
            Console.WriteLine("Value:0");
        }
        else
        {
            Console.WriteLine("Value:1");
        }
    }
}

