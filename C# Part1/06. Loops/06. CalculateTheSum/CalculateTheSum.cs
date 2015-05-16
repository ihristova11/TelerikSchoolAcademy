//Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateTheSum
{
    static void Main()
    {
        decimal S = 1.00m;
        int counter;
        Console.Write("N=");
        int N = int.Parse(Console.ReadLine());
        Console.Write("X=");
        int X = int.Parse(Console.ReadLine());
        decimal xAtPowerN = 1.00m;
        decimal factorial = 1.00m;
        for (counter = 1; counter <= N; counter++)
        {
            factorial *= counter;
            xAtPowerN *= X;
            S += (factorial / xAtPowerN);
        }
        
        Console.WriteLine("S={0}", S);
    }
}

