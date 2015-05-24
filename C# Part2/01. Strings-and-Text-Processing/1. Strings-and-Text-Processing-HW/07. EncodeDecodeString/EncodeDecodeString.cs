//Write a program that encodes and decodes
//a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR 
//(exclusive or) operation over the first letter of
//the string with the first of the key, the second – 
//with the second, etc. When the last key character is 
//reached, the next is the first.

namespace _07.EncodeDecodeString
{
    using System;
    using System.Text;
    class EncodeDecodeString
    {

        static string EncodeString(string text, string cipher)
        {
            var encoded = new StringBuilder();
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                encoded.Append((char)(text[i] ^ cipher[index]));
                if (index + 1 < cipher.Length)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
            }

            return encoded.ToString();
        }
        static string DecodeString(string text, string cipher)
        {
            return EncodeString(text, cipher);
        }

        static void Main()
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            Console.Write("Enter a chiper: ");
            string cipher = Console.ReadLine();

            string encodedText = EncodeString(text, cipher);
            Console.WriteLine("After encoding: " + encodedText);

            string decodedText = DecodeString(encodedText, cipher); //Decoding is the same as encoding
            Console.WriteLine("After decoding: " + decodedText);

        }
    }
}
