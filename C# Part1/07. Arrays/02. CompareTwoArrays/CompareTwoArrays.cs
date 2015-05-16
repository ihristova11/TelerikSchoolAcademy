//Write a program that reads two arrays from the console
//and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter the length of the first array:");
        int length = int.Parse(Console.ReadLine());        
        Console.Write("Enter the length of the second array:");
        int secondLength = int.Parse(Console.ReadLine());        
        if (length == secondLength)
        {
            int[] firstArray = new int[length];
            int counter;
            int counterS = 0;
            for (counter = 0; counter < length; counter++)
            {
                Console.Write("Enter {0} value for the first array:", counter);
                firstArray[counter] = int.Parse(Console.ReadLine());
            }
            int[] secondArray = new int[length];
            for (counter = 0; counter < length; counter++)
            {
                Console.Write("Enter {0} value for the second array:", counter);
                secondArray[counter] = int.Parse(Console.ReadLine());
            }
            for (counter = 0; counter < length; counter++)
            {
                if (firstArray[counter] == secondArray[counter])
                {
                    counterS++;
                }
            }
            if (counterS == counter)
            {
                Console.WriteLine("The two arrays are identical.");
            }
            else
            {
                Console.WriteLine("The two arrays aren't identical.");
            }
        }
        else
        {
            Console.WriteLine("The two arrays aren't identical.");
        }
    }
}

