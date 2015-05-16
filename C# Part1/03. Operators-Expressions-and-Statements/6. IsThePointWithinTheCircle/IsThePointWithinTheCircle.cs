using System;

class IsThePointWithinTheCircle
{
    static void Main()
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());
        if (x * x + y * y < 25)
        {
            Console.WriteLine("The point is within the circle.");
        }
        else
        {
            Console.WriteLine("The point isn't within the circle.");
        }
    }
}

