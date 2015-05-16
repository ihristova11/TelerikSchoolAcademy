
 //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
 //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 //Each member of the Fibonacci sequence (except the first two) 
 //is a sum of the previous two members.
 
using System;
using System.Numerics;

    class FibonacciSum
    {
        static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            BigInteger firstN = 0;
            BigInteger secondN = 1;
            BigInteger nextN;
            int counter = 0;
            while (counter < n)
            {
                nextN = firstN + secondN;
                sum = sum + firstN;
                firstN = secondN;
                secondN = nextN;
                counter++;
            }
            Console.WriteLine("The sum of the first {0} Fibonacci members is:{1}",n ,sum);
        }
    }