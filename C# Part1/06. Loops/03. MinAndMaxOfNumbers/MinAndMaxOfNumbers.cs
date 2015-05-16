//Write a program that reads from the console a sequence of N integer numbers
//and returns the minimal and maximal of them.

using System;

class MinAndMaxOfNumbers
{
    static void Main()
    {
        Console.Write("Set the size of the sequence:");
        int size = int.Parse(Console.ReadLine());
        int max = 0;
        int min = 0;
        int counter;
        int prevNum = 0;
        int num;
        for (counter = 1; counter <= size; counter++)
        {
            num = int.Parse(Console.ReadLine());
            if (max < num)
            {
                max = num;
            }
            if (size == 1)
            {
                min = max = size;
            }
            min = max;
            if (prevNum >= num && min > num)
            {
                min = num;
            }
            prevNum = num;
        }
        Console.WriteLine("The minimal value is:{0}\nThe maximal value is:{1}",min,max);
    }
}
