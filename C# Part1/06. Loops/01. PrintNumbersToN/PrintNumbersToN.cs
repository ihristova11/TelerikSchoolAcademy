//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbersToN
{
    static void Main()
    {
        Console.Write("N=");
        int N = int.Parse(Console.ReadLine());
        int counter;
        for (counter = 1; counter <= N; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}

