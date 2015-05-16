using System;

class HelloWorldProgram
{
    static void Main()
    {
        string greetingVariable = "Hello";
        string locationVariable = "World";
        object fullGreating = greetingVariable + " " + locationVariable + "!";
        string fullGreatingString = (string)fullGreating;
        Console.WriteLine(fullGreatingString);
    }
}
