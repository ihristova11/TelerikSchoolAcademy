using System;

class NNumbersSum
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int counter;
        for (counter = 1; counter <= n; counter++)
        {
            Console.Write("Enter number №{0}:",counter);
            int numberN = int.Parse(Console.ReadLine());
            sum = sum + numberN;
        }
        Console.WriteLine("The sum of the n numbers is {0}.", sum);
    }
}

