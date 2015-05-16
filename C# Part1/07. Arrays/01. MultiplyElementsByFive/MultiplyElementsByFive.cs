//Write a program that allocates array of 20 integers
//and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class MultiplyElementsByFive
{
    static void Main()
    {
        int[] array = new int[20];
        int index;
        for (index = 0; index <= 19; index++)
        {
            array[index] = index * 5;
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }
}

