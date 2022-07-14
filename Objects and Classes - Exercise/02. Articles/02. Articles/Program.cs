using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            Article article = new Article(input[0], input[1], input[2]);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
    }
    }

