/* Write a program that reads from the console a positive integer number N (N < 20) 
 * and outputs a matrix like the following:
 *  N = 3   N = 4
 *  1 2 3   1 2 3 4
 *  2 3 4   2 3 4 5
 *  3 4 5   3 4 5 6
 *          4 5 6 7
 */
using System;

class OutputMatrix
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        int row, col;
        if (n > 0 && n < 20)
        {
            for (row = 1; row <= n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", col + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}

