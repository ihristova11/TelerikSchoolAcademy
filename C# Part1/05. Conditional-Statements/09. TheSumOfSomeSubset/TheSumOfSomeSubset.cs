using System;

class TheSumOfSomeSubset
{
    static void Main()
    {
        Console.Write("Enter value of the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the fourth number:");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the fifth number:");
        int fifthNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        //1 digit check
        if (firstNumber == 0)
        {
            counter++;
        }
        if (secondNumber == 0)
        {
            counter++;
        }
        if (thirdNumber == 0)
        {
            counter++;
        }
        if (fourthNumber == 0)
        {
            counter++;
        }
        if (fifthNumber == 0)
        {
            counter++;
        }

        //2 digit check
        if (firstNumber + secondNumber == 0)
        {
            counter++;
        }
        if (firstNumber + thirdNumber == 0)
        {
            counter++;
        }
        if (firstNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + thirdNumber == 0)
        {
            counter++;
        }
        if (secondNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (thirdNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (thirdNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (fourthNumber + fifthNumber == 0)
        {
            counter++;
        }

        //3 digit check
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            counter++;
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }

        //4 digit check
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }

        //5 digit check
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            counter++;
        }

        //Display result
        if (counter >= 1)
        {
            Console.WriteLine("There are {0} subset sums, that are 0."
                                , counter);
        }
        else
        {
            Console.WriteLine("There are none subset sums, that are 0.");
        }
    }
}

