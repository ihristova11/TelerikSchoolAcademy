//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
//it the current directory. Find in Google how to download
//files in C#. Be sure to catch all exceptions and to free 
//any used resources in the finally block.

namespace _04.FileDownloader
{
    using System;
    using System.Net;
    class FileDownloader
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            using(webClient)
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"c:\Users\Irina\Desktop\New folder\test.jpg");
            }
            catch (ArgumentException ex1)
            {
                Console.WriteLine("{0} - {1}", ex1.GetType(), ex1.Message);                
            }                        
            catch(WebException ex2)
            {
                Console.WriteLine("{0} - {1}", ex2.GetType(), ex2.Message);
            }
            catch(NotSupportedException ex3)
            {
                Console.WriteLine("{0} - {1}", ex3.GetType(), ex3.Message);
            }
            catch(Exception all)
            {
                Console.WriteLine("{0} - {1}", all.GetType(), all.Message);
            }
        }
    }
}
