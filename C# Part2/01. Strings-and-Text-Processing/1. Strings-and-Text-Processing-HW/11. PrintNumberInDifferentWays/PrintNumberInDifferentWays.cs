//Write a program that reads a number and prints it 
//as a decimal number, hexadecimal number, percentage
//and in scientific notation. Format the output aligned right in 15 symbols.

namespace _11.PrintNumberInDifferentWays
{
    using System;
    class PrintNumberInDifferentWays
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            string result = string.Format("{0,15:D}\n{0,15:X4}\n{0,15:P0}\n{0,15:E}", number);
            Console.WriteLine(result);
        }
    }
}
