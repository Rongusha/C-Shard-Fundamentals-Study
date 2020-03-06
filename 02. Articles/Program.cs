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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initials = Console.ReadLine().Split(", ").ToList();

            Article article = new Article(initials[0], initials[1], initials[2]);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                string[] actions = command.Split(": ");

                if (actions[0]=="Edit")
                {
                    article.Edit(actions[1]);
                }
                else if (actions[0]== "ChangeAuthor")
                {
                    article.ChangeAuthor(actions[1]);
                }
                else if (actions[0]=="Rename")
                {
                    article.Rename(actions[1]);
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
