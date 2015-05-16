//Write a program that calculates N!/K!
//for given N and K (1<K<N).

using System;
using System.Numerics;

class CalculateFactorials
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K<N\tK=");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1, kFact = 1;
        int counter;
        if (k < n)
        {
            for (counter = 1; counter <= n; counter++)
            {
                nFact = nFact * counter;
            }
            for (counter = 1; counter <= k; counter++)
            {
                kFact = kFact * counter;
            }
            Console.WriteLine(nFact / kFact);
        }
        else
        {
            Console.WriteLine("N must be greater than K!");
        }
        
    }
}

