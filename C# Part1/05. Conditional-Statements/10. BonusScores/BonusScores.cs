using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit [1-9]:");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 1: Console.WriteLine(digit * 10); break;
            case 2: Console.WriteLine(digit * 10); break;
            case 3: Console.WriteLine(digit * 10); break;
            case 4: Console.WriteLine(digit * 100); break;
            case 5: Console.WriteLine(digit * 100); break;
            case 6: Console.WriteLine(digit * 100); break;
            case 7: Console.WriteLine(digit * 1000); break;
            case 8: Console.WriteLine(digit * 1000); break;
            case 9: Console.WriteLine(digit * 1000); break;
            default: Console.WriteLine("The value is 0 or isn't a digit."); break;
        
        }
    }
}

