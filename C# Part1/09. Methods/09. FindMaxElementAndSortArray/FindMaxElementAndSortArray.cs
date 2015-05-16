//Write a method that return the maximal element in
//a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class FindMaxElementAndSortArray
{
   static int MaxElementInArrPortion(int[] array, int givenIndex)
    {
        int biggestIndex = givenIndex;
        for (int i = givenIndex; i < array.Length; i++)
        {
            if (array[givenIndex] < array[i])
            {
                biggestIndex = i;
            }
        }
        return array[biggestIndex];
    }

    static void SortArrayAscending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
       }
    }

    static void SortArrayDescending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
        }
        Array.Reverse(array);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
   
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the element {0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the array index to start the check:");
        int givenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximal element in this array portion is: {0}", MaxElementInArrPortion(array, givenIndex));
        Console.WriteLine("Enter number 1 if you want to sort the array in Ascending order: ");
        Console.WriteLine("Enter number 2 if you want to sort the array in Descending order: ");
        int howToSort = int.Parse(Console.ReadLine());

        if (howToSort == 1)
        {
            SortArrayAscending(array);
            PrintArray(array);
        }

        if (howToSort == 2)
        {
            SortArrayDescending(array);
            PrintArray(array);
        }

        else if (howToSort != 1 && howToSort !=2)
        {
            Console.WriteLine("Error! Try Again!");
        }
    }
    }



