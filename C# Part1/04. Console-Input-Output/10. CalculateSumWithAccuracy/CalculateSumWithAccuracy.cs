using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        double sum = 1.0f;
        for (double counter = 2; 1 / counter >= 0.001; counter++)
        {
            if (counter % 2 == 0)
            {
                sum = sum + 1 / counter;
            }
            else
            {
                sum = sum - 1 / counter;
            }
        }
        Console.WriteLine("The sum is:{0:F10}",sum);
    }
}

