using System;

class CheckCoordinates
{
    static void Main()
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());
        if (x * x + y * y < 9)
        {
            if ((y < 1) && (y > -1) && (x > -1) && (x < 5))
            {
                Console.WriteLine("The point is within the circle and the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is within the circle and without the rectangle.");
            }
        }
        else
        {
            Console.WriteLine("The point is without the circle.");
        }
    }
}

