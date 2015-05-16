using System;

class BitPosition
{
    static void Main()
    {
        bool isTheBitOne = true;
        Console.Write("Number:");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Position of the bit:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        if (vAndMask == 0)
        {
            isTheBitOne = false;
        }
        else
        {
            isTheBitOne = true;
        }
        Console.WriteLine(isTheBitOne);
    }
}

