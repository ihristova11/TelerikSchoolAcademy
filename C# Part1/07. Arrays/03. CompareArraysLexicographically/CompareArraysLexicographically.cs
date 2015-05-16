//Write a program that compares two char arrays 
//lexicographically (letter by letter).

using System;

class CompareArraysLexicographically
{
    static void Main()
    {
        int counter;
        int counterS = 0;
        Console.Write("Enter the length of the first array:");
        int flength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[flength];
        Console.Write("Enter the length of the second array:");
        int slength = int.Parse(Console.ReadLine());
        char[] secondArray = new char[slength];
        if (flength == slength)
        {
            for (counter = 0; counter < flength; counter++)
            {
                Console.Write("Enter {0} value for the first array:", counter);
                firstArray[counter] = char.Parse(Console.ReadLine());
            }
            for (counter = 0; counter < slength; counter++)
            {
                Console.Write("Enter {0} value for the second array:", counter);
                secondArray[counter] = char.Parse(Console.ReadLine());
            }
            for (counter = 0; counter < flength; counter++)
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

