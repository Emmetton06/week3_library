using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}