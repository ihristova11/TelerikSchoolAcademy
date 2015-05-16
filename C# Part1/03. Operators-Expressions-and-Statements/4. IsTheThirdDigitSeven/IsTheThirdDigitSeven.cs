using System;

class IsTheThirdDigitSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int digit1 = number % 10;
        int digit2 = (number / 10) % 10;
        int digit3 = (number / 100) % 10;
        if (digit3 == 7)
        {
            Console.WriteLine("The third number(right-to-left) is 7.");
        }
        else
        {
            Console.WriteLine("The third number(right-to-left) isn't 7.");
        }
    }
}
