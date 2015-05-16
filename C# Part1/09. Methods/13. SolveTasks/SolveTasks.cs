using System;

class SolveTasks
{
    //Reverses the digits of a number
    public static void ReverseNumber(int number)
    {
        int newNumber = 0;
        while (number > 0)
        {
            newNumber = (newNumber * 10) + (number % 10);
            number /= 10;
        }
        Console.WriteLine("The reversed number is {0}.", newNumber);
    }
    //Calculates the average of a sequence of integers
    public static void CalculateTheAverage(int[] numbers)
    {
        double sum = 0;
        for (int count = 0; count < numbers.Length; count++)
        {
            sum = sum + numbers[count];
        }
        double average = sum / numbers.Length;
        Console.WriteLine("The average of the sequence is {0:0.00}.",average);
    }
    //Solves a linear equation a * x + b = 0
    static void SolveLinearEquation(decimal a, decimal b)
    {
        if (a != 0)
        {
            decimal x = -b / a;
            Console.WriteLine("x={0:0.00}",x);
        }
        else
        {
            Console.WriteLine("Error!");
        }
       
    }
    static void Main()
    {
        Console.WriteLine("Choose a program that:");
        Console.WriteLine("1.Reverses the digits of a number(press 1)");
        Console.WriteLine("2.Calculates the average of a sequence of integers(press 2)");
        Console.WriteLine("3.Solves a linear equation a * x + b = 0(press 3)");
        Console.Write("Enter your choice(1,2 or 3):");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1 || choice == 2 || choice == 3)
        {
            if (choice == 1)
            {
                Console.WriteLine("----------------------Reverse the digit of a number----------------------");
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                ReverseNumber(number);
            }
            if (choice == 2)
            {
                Console.WriteLine("-------------Calculate the average of a sequence of integers-------------");
                Console.Write("Enter the length of the array:");
                int length = int.Parse(Console.ReadLine());
                int[] numbers = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.Write("Enter the element {0}:", i);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                CalculateTheAverage(numbers);
            }
            if (choice == 3)
            {
                Console.WriteLine("-----------------Solves a linear equation a * x + b = 0-----------------");
                Console.Write("a=");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("b=");
                decimal b = decimal.Parse(Console.ReadLine());
                SolveLinearEquation(a, b);
            }
        }
        else
        {
            Console.WriteLine("You must enter 1, 2 or 3.");
        }
    }
}

