using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Integer variable with Null value: " + nullInt);
        Console.WriteLine("Double variable with Null value: " + nullDouble + "\n");
        Console.WriteLine("The nullable integer variable with some value: " + (nullInt + 10));
        Console.WriteLine("The nullable double variable with some value: " + (nullDouble + 10) + "\n");
        nullInt = 5;
        nullDouble = 5.0;
        Console.WriteLine("Get Value Or Default: " + nullInt.GetValueOrDefault());
        Console.WriteLine("Get Value Or Default: " + nullDouble.GetValueOrDefault());
        
    }
}

