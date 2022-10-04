using System;

namespace Book
{
    class Book
    {
        public Book()
        {
            Console.Write("Введiть назву книги: ");
            string t = Console.ReadLine();

            Console.Write("Введiть автора книги: ");
            string a = Console.ReadLine();

            Console.Write("Введiть змiст книги: ");
            string c = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Iнформацiя : ");

            Title title = new Title(t);
            title.Show();

            Author author = new Author(a);
            author.Show();

            Content content = new Content(c);
            content.Show();
        }
    }
     class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Назва: {title}");
        }
    }
     class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Автор: {author}");
        }    }
    class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Змiст: {content}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}