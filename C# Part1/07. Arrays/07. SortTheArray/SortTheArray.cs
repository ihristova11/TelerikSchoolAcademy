//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;

class SortTheArray
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }
        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (myArray[j] < min)
                {
                    min = myArray[j];
                    minIndex = j;
                }
            }
            temp = myArray[i];
            myArray[i] = min;
            myArray[minIndex] = temp;
            min = int.MaxValue;
        }

        for (int index = 0; index < n; index++)
        {
            Console.Write("{0} ", myArray[index]);
        }

    }
}

