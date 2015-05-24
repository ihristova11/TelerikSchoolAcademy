//Write a program that replaces in a HTML
//document given as string all the tags <a href="…">…</a>
//with corresponding tags [URL=…]…/URL]. 
namespace _15.HTMLTags
{
    using System;
    class HTMLTags
    {
        static void Main()
        {
            string html = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string replaced = html.Replace("<a href=\"", "[URL=").Replace("</a>", "[/URL]").Replace("\">", "]");

            Console.WriteLine("Result: \n" + replaced);
        }
    }
}
