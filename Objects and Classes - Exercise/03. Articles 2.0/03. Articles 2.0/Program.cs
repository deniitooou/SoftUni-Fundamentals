using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }

            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
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
    }
    }

