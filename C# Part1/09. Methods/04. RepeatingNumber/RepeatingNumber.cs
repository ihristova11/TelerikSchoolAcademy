//Write a method that counts how many times given number 
//appears in given array. Write a test program to check
//if the method is working correctly.

using System;

class RepeatingNumber
{
    static void CountAppearences(int[] array, int number)
    {
        int counter = 0;
        for (int count = 0; count < array.Length; count++)
        {
            if (array[count] == number)
            {
                counter++;
            }
        }
        Console.WriteLine("The searched number is repeting {0} times.",counter);
    }
    static void Main()
    {
        Console.Write("Enter the length of the array:");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter the element {0}:",index);
            array[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the searched number:");
        int number = int.Parse(Console.ReadLine());        
        CountAppearences(array, number);
    }
}
