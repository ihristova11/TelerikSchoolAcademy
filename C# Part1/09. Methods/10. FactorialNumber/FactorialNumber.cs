using System;
using System.Numerics;

class FactorialNumber
{    
        static BigInteger CalcualteFactorial(int[] array, int n)
        {
            BigInteger result = 1;
            for (int count = 1; count <= n; count++)
            {
                result = result * array[count];
            }
            return result;
        }

        static void Main()
        {
            int[] hundredNumbers = new int[100];
            for (int i = 1; i < 100; i++)
            {
                hundredNumbers[i] = i;

            }
            foreach (var item in hundredNumbers)
            {
                Console.WriteLine(CalcualteFactorial(hundredNumbers, item));
            }
        }
    }


