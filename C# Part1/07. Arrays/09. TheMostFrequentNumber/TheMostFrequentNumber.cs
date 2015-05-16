//Write a program that finds the most frequent number in an array.
//Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class TheMostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the number of elements:");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter the element {0}:", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }
            }
        }
        int currentCount = 1;
        int maxCount = 1;
        int number = 0;
        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] == array[index - 1])
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
                number = array[index];
            }
        }
        if (length == 1)
        {
            maxCount = 1;
            number = array[0];
        }
        Console.WriteLine("{0} -> {1} times", number, maxCount);
    }
}


