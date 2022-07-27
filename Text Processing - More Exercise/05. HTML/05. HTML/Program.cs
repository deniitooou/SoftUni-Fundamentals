using System;
using System.Text;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            output.AppendLine("<h1>");
            output.AppendLine($"    {title}");
            output.AppendLine("</h1>");

            output.AppendLine("<article>");
            output.AppendLine($"    {article}");
            output.AppendLine("</article>");

            string inputComment = Console.ReadLine();
            while (inputComment != "end of comments")
            {
                output.AppendLine("<div>");
                output.AppendLine($"    {inputComment}");
                output.AppendLine("</div>");

                inputComment = Console.ReadLine();
            }

            Console.WriteLine(output.ToString());
        }
    }
}
