//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 
using System;

class LongestSequenceInMatrix
{
    static void PrintMatrix(string[,] matrix)
    {
        int cellSize = matrix[0, 0].Length;
        foreach (string cell in matrix) cellSize = Math.Max(cellSize, cell.Length);

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j].PadRight(cellSize, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
    }

    static bool IsTraversable(string[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }

    static int maxSum = 0;
    static string maxValue;

    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };
    static void DFS(string[,] matrix, bool[, ,] used, int row, int col)
    {
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            if (used[row, col, direction]) continue;
            int currentSum = 0;
            int _row = row, _col = col;

            while (IsTraversable(matrix, _row, _col) && matrix[row, col] == matrix[_row, _col])
            {
                currentSum++;

                used[_row, _col, direction] = true;

                _row += directions[direction, 0];
                _col += directions[direction, 1];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxValue = matrix[row, col];
            }
        }
    }

    static void Main()
    {
        string[,] matrix = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
        // string[,] matrix = { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };

        bool[, ,] used = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                DFS(matrix, used, i, j);

        PrintMatrix(matrix);
        Console.WriteLine(maxValue + " " + maxSum);
    }
}

