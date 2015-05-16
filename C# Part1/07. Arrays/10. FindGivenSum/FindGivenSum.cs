using System;

class FindGivenSum
{
    static void Main()
    {
        Console.Write("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter the element {0}:", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the sum:");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        bool solution = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                sum += array[j];
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The following sequence has the sum of {0}: ", s);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", array[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        if (!solution)
        {
            Console.WriteLine("Ain't no sequnce with the sum of {0}!", s);
        }
    }
}

