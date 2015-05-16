using System;

class PrintTheNumbers
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        int counter;
        for (counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}

