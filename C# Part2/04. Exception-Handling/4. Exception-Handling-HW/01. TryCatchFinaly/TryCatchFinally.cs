//Write a program that reads an integer number
//and calculates and prints its square root.
//If the number is invalid or negative, print 
//"Invalid number". In all cases finally print 
//"Good bye". Use try-catch-finally.

namespace _01.TryCatchFinally
{
    using System;
    class Program
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number. {0}", fe.Message);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("The argument is null.");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
