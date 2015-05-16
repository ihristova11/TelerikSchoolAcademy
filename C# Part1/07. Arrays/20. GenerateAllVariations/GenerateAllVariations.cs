//Write a program that reads two numbers N and K and generates all
//the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class GenerateAllVariations
{
    static void Print(int[] Array)
    {

        for (int i = 0; i <= Array.Length - 1; i++)
        {
            Console.Write("{0} ", Array[i]);
        }
        Console.WriteLine("\n");
    }

    static void Find(int[] Container, int j, int N)
    {
        if (j == Container.Length)
        {
            Print(Container);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                Container[j] = i;
                Find(Container, j + 1, N);
            }
        }
    }
    static void Main()
    {
        int N;
        int K;
        do
        {
            Console.Write("Insert N:");
            N = int.Parse(Console.ReadLine());
        }
        while (N <= 0);
        do
        {
            Console.Write("Insert K:");
            K = int.Parse(Console.ReadLine());
        }
        while (K <= 0);
        Console.WriteLine();

        int[] Container = new int[K];
        Find(Container, 0, N);
    }
}

