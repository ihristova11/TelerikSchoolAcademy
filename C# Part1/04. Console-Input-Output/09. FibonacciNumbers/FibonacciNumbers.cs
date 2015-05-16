using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        BigInteger firstN = 0;
        BigInteger secondN = 1;
        BigInteger nextN;
        int counter = 0;
        while(counter <= 100)
        {
            nextN = firstN + secondN;
            Console.WriteLine("{0} - " + firstN, counter);
            firstN = secondN;
            secondN = nextN;
            counter++;
        }
    }
}

