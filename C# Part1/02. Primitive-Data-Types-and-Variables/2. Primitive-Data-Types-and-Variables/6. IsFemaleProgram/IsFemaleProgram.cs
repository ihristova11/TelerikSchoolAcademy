using System;

class IsFemaleProgram
{
    static void Main()
    {
        bool isFemale = true;
        Console.Write("Enter your gender[female/male]:");
        string name = Console.ReadLine();
        if (name != "female")
        {
            Console.WriteLine("You are a man.");
        }
        else
        {
            Console.WriteLine("You are a woman.");
        }
    }
}

