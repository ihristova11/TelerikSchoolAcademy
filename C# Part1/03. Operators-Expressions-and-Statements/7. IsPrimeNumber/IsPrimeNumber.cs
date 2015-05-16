using System;

class IsPrimeNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 100)
        {
            int divider = 2;
            int secondDivider = (int)Math.Sqrt(n);
            bool isPrime = true;
            while(isPrime && (divider <= secondDivider))
            {
                if (n % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime:{0}", isPrime);
        }
        else
        {
            Console.WriteLine("n > 100");
        }
    }
}

