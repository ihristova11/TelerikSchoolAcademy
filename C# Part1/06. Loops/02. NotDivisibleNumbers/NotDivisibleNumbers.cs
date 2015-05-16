//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.

using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        Console.Write("N=");
        int N = int.Parse(Console.ReadLine());
        int counter;
        for (counter = 1; counter <= N; counter++)
        {
            if (counter % 21 != 0)
            {
                Console.WriteLine(counter);
            }
        }
    }
}

