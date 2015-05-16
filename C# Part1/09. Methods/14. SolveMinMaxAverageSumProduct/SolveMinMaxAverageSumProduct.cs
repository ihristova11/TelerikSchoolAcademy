//Write methods to calculate minimum, maximum, average,
//sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;

class SolveMinMaxAverageSumProduct
{
    static void FindTheSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("The sum of the elements is {0}.", sum);
    }
    static void CalculateTheAverage(int[] numbers)
    {
        double sum = 0;
        for (int count = 0; count < numbers.Length; count++)
        {
            sum = sum + numbers[count];
        }
        double average = sum / numbers.Length;
        Console.WriteLine("The average of the sequence is {0:0.00}.", average);
    }
    static void FindTheMaxNumber(int[] numbers)
    {
        int max = int.MinValue;
        for (int count = 0; count < numbers.Length; count++)
        {
            if (numbers[count] > max)
            {
                max = numbers[count];
            }
        }
        Console.WriteLine("The maximal number is {0}.", max);
    }
    static void FindTheMinNumber(int[] numbers)
    {
        int min = int.MaxValue;
        for (int count = 0; count < numbers.Length; count++)
        {
            if (numbers[count] < min)
            {
                min = numbers[count];
            }
        }
        Console.WriteLine("The minimal number is {0}.", min);
    }
    static void Main()
    {
        Console.Write("Enter the length of the array:");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter the element {0}:",index);
            numbers[index] = int.Parse(Console.ReadLine());
        }
            FindTheMinNumber(numbers);
            FindTheMaxNumber(numbers);
            CalculateTheAverage(numbers);
            FindTheSum(numbers);
    }
}

