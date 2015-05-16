//Write a method that checks if the element at given position
//in given array of integers is bigger than its two neighbors (when such exist).

using System;

class IsTheNumberBigger
{
    static void FindTheBiggerNumber(int[] array, int position)
    {
        if (position != 0)
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                Console.WriteLine("The number is bigger than it's neighbours.");
            }
            else
            {
                Console.WriteLine("The numbers is not bigger than it's neightbours.");
            }
        }
        if (position == 0 || position == array.Length - 1)
        {
            Console.WriteLine("The element has only one neighbour.");
        }
    }

    static void Main()
    {
        Console.Write("Enter the length of the array:");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int count = 0; count < length; count++)
        {
            Console.Write("Enter the element {0}:", count);
            array[count] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the position:");
        int position = int.Parse(Console.ReadLine());
        FindTheBiggerNumber(array, position);      
    }
}

