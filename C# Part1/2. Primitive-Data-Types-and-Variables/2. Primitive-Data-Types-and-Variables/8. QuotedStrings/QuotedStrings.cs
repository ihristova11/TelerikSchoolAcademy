using System;

class QuotedStrings
{
    static void Main()
    {
        string firstTry = "The \"use\" of quotations cause difficulties.";
        string secondTry = @"The ""use"" of quotations cause difficulties.";
        Console.WriteLine(firstTry);
        Console.WriteLine(secondTry);
    }
}

