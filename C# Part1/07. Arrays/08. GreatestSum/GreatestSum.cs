//Write a program that finds the sequence of maximal sum in given array.
//Example:{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class GreatestSum
{
    static void Main()
    {
        Console.Write("Enter number of elements:");
        int length = int.Parse(Console.ReadLine());
        int[] myArray = new int[length];
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter element {0}: ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }

        int maxSum = myArray[0], currentSum = myArray[0];
        int start = 0, startTemp = 0, end = 0;
        for (int i = 1; i < myArray.Length; i++)
        {
            currentSum += myArray[i];
            if (currentSum < myArray[i])
            {
                currentSum = myArray[i];
                startTemp = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.Write("The sequence with maximal sum is: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
    }
}

