//Write a method GetMax() with two parameters 
//that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console 
//and prints the biggest of them using the method GetMax().

using System;

    class BiggerInteger
    {
        static int GetMax(int firstNum, int secondNum)
        {
            return firstNum > secondNum ? firstNum : secondNum;
        }
        static void Main()
        {
            Console.Write("Enter the first number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is:{0}",GetMax(GetMax(firstNum, secondNum), thirdNum));
            
        }
    }

