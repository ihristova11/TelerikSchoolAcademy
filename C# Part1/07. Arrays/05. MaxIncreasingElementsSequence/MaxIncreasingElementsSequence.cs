//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaxIncreasingElementsSequence
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] elements = new int[n];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            elements[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (elements[index] > elements[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = index + 1 - maxCount;
                }
            }
        }

        Console.Write("The maximal increasing sequence of elements is: ");
        for (int index = sequenceStart; index < sequenceStart + maxCount; index++)
        {
            Console.Write("{0} ", elements[index]);
        }
    }
}

