//Write a program that calculates N!*K! / (K-N)!
//for given N and K (1<N<K).

using System;
using System.Numerics;

class CalculateNFactMultiplyKFact
{
    static void Main()
    {
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        Console.Write("N<K" + " " + "N=");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1, kFact = 1, factKN = 1;
        int counter;
        if (n < k)
        {
            for (counter = 1; counter <= k; counter++)
            {
                kFact = kFact * counter;
            }
            for (counter = 1; counter <= n; counter++)
            {
                nFact = nFact * counter;
            }
            for (counter = 1; counter <= k - n; counter++)
            {
                factKN = factKN * counter;
            }
            Console.WriteLine("N!*K! / (K-N)! is:{0}", (nFact * kFact) / factKN);
        }
        else
        {
            Console.WriteLine("K must be greater than N!");
        }
    }
}

