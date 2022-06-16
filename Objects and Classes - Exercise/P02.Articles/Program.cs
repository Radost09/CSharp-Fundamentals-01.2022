using System;
using System.Linq;

namespace P02.Articles
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

        public void Rename(string title)
        {
            Title = title;
        }
        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAutor(string author)
        {
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(input[0], input[1], input[2]);
            int numCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numCommands; i++)
            {
                string[] articleArgs = Console.ReadLine().Split(": ").ToArray();
                string action = articleArgs[0];
                string changes = articleArgs[1];

                if (action == "Rename")
                {
                    article.Rename(changes);
                }
                if (action == "Edit")
                {
                    article.Edit(changes);
                }
                if(action == "ChangeAuthor")
                {
                    article.ChangeAutor(changes);
                } 
            }
            Console.WriteLine(article);
        }
    }
}
