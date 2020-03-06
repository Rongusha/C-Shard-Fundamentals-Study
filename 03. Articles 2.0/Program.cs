using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


    }
    class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < num; i++)
            {
                List<string> initials = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(initials[0], initials[1], initials[2]);

                articles.Add(article);
            }

            string command = Console.ReadLine();

            OrderBy(articles, command);
        }

        public static void OrderBy(List<Article> articles, string command)
        {
            if (command == "title")
            {
                IEnumerable<Article> ordered = articles.OrderBy(Article => Article.Title);

                foreach (Article article in ordered)
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            else if (command == "content")
            {
                IEnumerable<Article> ordered = articles.OrderBy(Article => Article.Content);

                foreach (Article article in ordered)
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            else if (command == "author")
            {
                IEnumerable<Article> ordered = articles.OrderBy(Article => Article.Content);

                foreach (Article article in ordered)
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            else
            {
                foreach (Article article in articles)
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
        }
    }
}
