using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
{
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string orderBy = Console.ReadLine();
            if(orderBy == "title")
            {
                articles = articles.OrderBy(t => t.Title).ToList();
            }
            else if(orderBy == "content")
            {
                articles = articles.OrderBy(c => c.Content).ToList();
            }
            else if(orderBy == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }
            Console.WriteLine(String.Join(Environment.NewLine, articles));
        }
    }
}
