//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int length = int.Parse(Console.ReadLine());
        int[] elements = new int[length];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter element {0}: ", index);
            elements[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (elements[index] == elements[index - 1])
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

        Console.Write("The maximal sequence of equal elements is: ");
        for (int index = sequenceStart; index < sequenceStart + maxCount; index++)
        {
            Console.Write("{0} ", elements[index]);
        }
    }
}

