using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Height:");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle's area is " + width * height + ".");
    }
}