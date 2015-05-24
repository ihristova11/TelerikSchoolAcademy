//Write a program that enters file name along with
//its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print
//user-friendly error messages.

namespace _03.FileReader
{
    using System;
    using System.IO;
    class FileReader
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the files location: ");
                string location = Console.ReadLine();
                string textContent = File.ReadAllText(location);
            }
            catch (DirectoryNotFoundException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FileNotFoundException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(ArgumentNullException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch(ArgumentException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch(PathTooLongException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
            catch(Exception ex6)
            {
                Console.WriteLine("{0} - {1}", ex6.GetType(),ex6.Message);
            }
        }
    }
}
