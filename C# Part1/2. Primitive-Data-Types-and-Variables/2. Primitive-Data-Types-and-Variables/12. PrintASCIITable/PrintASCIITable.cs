using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\t \t \t \t ASCII Table\n");
        byte counter = 0;
        char symbol = Convert.ToChar(counter);
        for (counter = 0; counter <= 127; counter++)
        {
            Console.Write("{0} - {1}\t", counter, (char)counter);
        }
        Console.WriteLine();
    }
}