//Write a program that extracts from given HTML 
//file its title (if available), and its
//body text without the HTML tags. 
namespace _25.ExtractFromHTML
{
    using System;
    using System.IO;
    class ExtractFromHTML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("text.txt");
            using (reader)
            {
                string line = reader.ReadToEnd();
                int closeIndex = line.IndexOf('>');
                while (closeIndex > -1)
                {
                    if (closeIndex < line.Length - 1 && line[closeIndex + 1] != '<')
                    {
                        int nextOpenIndex = line.IndexOf('<', closeIndex);
                        int textLength = nextOpenIndex - closeIndex - 1;
                        Console.WriteLine(line.Substring(closeIndex + 1, textLength));
                    }
                    closeIndex = line.IndexOf('>', closeIndex + 1);
                }
            }
        }
    }
}
