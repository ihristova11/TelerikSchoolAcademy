using System;

class AreaPerimeterOfCircle
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double circleArea = Math.PI * radius * radius;
        double circlePerimeter = Math.PI * 2 * radius;
        Console.WriteLine("The circle's area is {0:0.00}.", circleArea);
        Console.WriteLine("The circle's perimeter is {0:0.00}.", circlePerimeter);
    }
}

