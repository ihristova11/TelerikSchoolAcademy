//Write a method that asks the user for his name
//and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;

    class PrintYourName
    {
        static void PrintName()
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is {0}.", name);
    }
        static void Main()
        {
            PrintName();
        }
    }

