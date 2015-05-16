using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int someInteger = int.Parse(Console.ReadLine());
        if (someInteger % 2 == 0)
        {
            Console.WriteLine("This number is even.");
        }
        else
        {
            Console.WriteLine("This number is odd.");
        }
    }
}

