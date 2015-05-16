using System;

class SolveTheQuadraticEquation
{
    static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        double x1, x2;
        if (a > 0)
        {
            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1={0}\nx2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Real roots don't exist.");
            }
        }
        else 
        {
            if (a == 0)
            {
                Console.WriteLine("The equation isn't quadratic.");
            }
            else
            {
                b = -b;
                a = -a;
                c = -c;
                D = b * b - 4 * a * c;
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1={0}\nx2={1}", x1, x2);

            }
        }
        

    }
}

