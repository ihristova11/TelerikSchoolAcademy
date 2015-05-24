//Write a method ReadNumber(int start, int end) that
//enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, 
//the method should throw an exception. Using this method 
//write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.ReadNumber
{
    using System;
    class ReadTheNumber
    {
        public static int ReadNumber(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start must be bigger than end!");
            }
            int firstNum = int.Parse(Console.ReadLine());
            if(firstNum < start ||firstNum > end)
            {
                throw new ArgumentOutOfRangeException("The number must be between the given start and end!");
            }
            return firstNum;
        }
        static void Main()
        {
            int min = 1;
            int max = 50;
            try
            {
            for (int count = 0; count < 10; count++)
            {
                Console.Write("Enter a number in the range {0} - {1}: ", min, max);
                max = ReadNumber(min, max);
            }
            }
            catch(FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(ArgumentOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(ArgumentException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch(Exception all)
            {
                Console.WriteLine("{0} - {1}", all.GetType(), all.Message);
            }
        }    
    }
}
