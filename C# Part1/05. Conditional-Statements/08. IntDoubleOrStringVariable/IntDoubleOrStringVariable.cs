using System;

class IntDoubleOrStringVariable
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double, and 3 for string:");
        int choice = int.Parse(Console.ReadLine());
        int intVariable;
        double doubleVariable;
        string stringVariable;
        switch (choice)
        {
            case 1: intVariable = int.Parse(Console.ReadLine());
                Console.WriteLine(intVariable + 1); break;
            case 2: doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleVariable + 1); break;
            case 3: stringVariable = Console.ReadLine();
                Console.WriteLine("{0}" + "*", stringVariable); break;
            default: Console.WriteLine("Invalid token (only the numbers 1, 2, 3)");
                break;
        }
        
    }
}

