//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {

        ulong N = 10000000;
        bool[] Array = new bool[N];
        for (ulong i = 0; i <= (ulong)Math.Sqrt(N); i++)
        {
            Array[i] = true;
        }

        for (ulong j = 2; j < N; j++)
        {
            if (Array[j] == true)
            {
                for (ulong k = j * j; k < N; k = k + j)
                {
                    Array[k] = false;


                }
            }
        }
        for (ulong d = 0; d < N; d++)
        {
            if (Array[d] == true)
            {
                Console.Write("{0} ", d);
            }
        }
    }
}

