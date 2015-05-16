using System;

class ChangeBits
{
    static void Main()
    {
        Console.Write("Number(n):");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Value(v = 1 or 0):");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Position(p):");
        int p = int.Parse(Console.ReadLine());
        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
            Console.WriteLine("Result:{0}", result);
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
            Console.WriteLine("Result:{0}", result);
        }
    }
}

