//Write a program to calculate the Nth Catalan 	number by given N.

using System;

class CatalanFormula
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        int counter;
        int catalanFormula;
        int n2Fact = 1; // 2n!
        int nFact = 1; // n!
        int n1Fact = 1; // (n+1)!
        for (counter = 1; counter <= 2 * n; counter++)
        {
            n2Fact = n2Fact * counter;
        }
        for (counter = 1; counter <= n; counter++)
        {
            nFact *= counter;
        }
        for (counter = 1; counter <= n + 1; counter++)
        {
            n1Fact *= counter;
        }
        catalanFormula = n2Fact / (nFact * n1Fact);
        Console.WriteLine("The {0} Catalan number is {1}.",n ,catalanFormula);
    }
}

