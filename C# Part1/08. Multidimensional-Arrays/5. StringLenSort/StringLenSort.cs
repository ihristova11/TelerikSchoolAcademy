using System;
using System.Linq;

class StringLenSort
{
    public class StringLengthSort
    {
        public static void Main()
        {
            string[] unsortedStrings = {"Kubrat", "Pulev", "is the", "CHAMPION!" };

            var sortedArray = unsortedStrings.OrderBy(uStrings => uStrings.Length);
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

