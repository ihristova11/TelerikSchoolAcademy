//Write a program that reads two numbers N and K
//and generates all the combinations of K distinct elements from the set [1..N]. Example:
//N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
using System;

class TwoNumbersNandKGenAllCombinations
{
    static int N;
    static int K;
    static int[] result;

    static void Main()
    {
        Console.Write("N=");
        N = int.Parse(Console.ReadLine());
        Console.Write("K=");
        K = int.Parse(Console.ReadLine());
        result = new int[K];
        Solve(0, 0);
    }

    private static void Solve(int position, int currentIndex)
    {
        if (position == result.Length)
        {
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            return;
        }

        for (int i = currentIndex + 1; i <= N; i++)
        {
            result[position] = i;
            currentIndex++;
            Solve(position + 1, currentIndex);
        }

    }
}
