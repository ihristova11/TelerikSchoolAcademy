using System;

class TheBit3OfGivenInteger
{
    static void Main()
    {
        Console.Write("Please write a number:");
        byte number = byte.Parse(Console.ReadLine());
        byte someNumber = 8;
        if ((someNumber & number) != 0)
        {
            Console.WriteLine("The third bit(counting form 0) is 1.");
        }
        else
        {
            Console.WriteLine("The third bit(counting form 0) is 0.");
        }
    }
}

