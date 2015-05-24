//Write a program that parses an URL address given in the format:

//        and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

namespace _12.ParseURL
{
    using System;
    class ParseURL
    {
        static void Main()
        {
            Console.Write("Enter URL:");
            string url = Console.ReadLine();
            int index = url.IndexOf("://");
            string protocol = url.Substring(0, index);
            int index1 = url.IndexOf('/', index + 3);
            string server = url.Substring(index + 3, index1 - index - 3);
            string resource = url.Substring(index1);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
