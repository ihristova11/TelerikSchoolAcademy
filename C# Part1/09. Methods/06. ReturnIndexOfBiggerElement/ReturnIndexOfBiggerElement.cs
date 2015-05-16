//Write a method that returns the index of the first element
//in array that is bigger than its neighbors, or -1, if there’s no such element.

using System;
using System.Linq;

class ReturnIndexOfBiggerElement
{
    public static int ReturnIndexOfFirstBiggest(int[] array)
    {
        for (int index = 1; index < array.Length - 1; index++)
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
        return 0;
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
        Console.WriteLine("The index of the first element that is bigger than ist's neighbours is:{0}",ReturnIndexOfFirstBiggest(array));
    }
}

