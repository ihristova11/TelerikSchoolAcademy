//Implement a set of extension methods for
//IEnumerable<T> that implement the following 
//group functions: sum, product, min, max, average.

namespace _02.MethodsForIEnumerable
{
    using System;
    using System.Collections.Generic;
    
    class MethodsForIEnumerable
    {
        static void Main()
        {

            int[] numbers = new int[4];
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i;
            }

            numbers[0] = 1;

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average());
        }
    }
}
