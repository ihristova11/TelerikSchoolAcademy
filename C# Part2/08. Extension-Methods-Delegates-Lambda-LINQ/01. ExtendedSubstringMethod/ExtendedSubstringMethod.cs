//Implement an extension method Substring(int index, int length)
//for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

namespace _01.ExtendedSubstringMethod
{
    using System;
using System.Text;
    public static class ExtendedSubstringMethod
    {
        public static StringBuilder Substring(this StringBuilder someString, int startPosition)
        {
            if(someString.Length >= startPosition)
            {
                throw new IndexOutOfRangeException("Length of the string must be larger than start index.");
            }
            StringBuilder returnString = new StringBuilder();
            returnString.Append(someString.ToString()).Substring(startPosition);
            return returnString;
        }

        public static StringBuilder Substring(this StringBuilder someString, int startPosition, int length)
        {
            if (someString.Length >= startPosition)
            {
                throw new IndexOutOfRangeException("Length of the string must be larger than start index.");
            }
            if (someString.Length >= startPosition + length)
            {
                throw new IndexOutOfRangeException("The length of the substring exceeds the characters of the StringBuilder after the start index.");
            }
            StringBuilder returnString = new StringBuilder();
            returnString.Append(someString.ToString()).Substring(startPosition, length);
            return returnString;
        }
        static void Main()
        {
        }
    }
}
