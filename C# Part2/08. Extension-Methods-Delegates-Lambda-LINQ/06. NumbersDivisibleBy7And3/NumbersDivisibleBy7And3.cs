//Write a program that prints from given
//array of integers all numbers that are 
//divisible by 7 and 3. Use the built-in
//extension methods and lambda expressions.
//Rewrite the same with LINQ.

namespace _06.NumbersDivisibleBy7And3
{
    using System;
    using System.Linq;
    class NumbersDivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = { 7, 3, 6, 5, 14, 15, 21 };
            //Using LINQ
            var divisible =
                from number in numbers
                where number % 21 == 0
                select number;
            Console.WriteLine("Numbers divisible by 7 and 3:");
            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Using lambda expressions
            var divisible1 = numbers.Where(num => num % 21 == 0);
            Console.WriteLine("Numbers divisible by 7 and 3:");
            foreach (var item1 in divisible1)
            {
                Console.WriteLine(item1);
            }
        }
    }
}
