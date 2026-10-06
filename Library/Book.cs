using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string _title; // private field
        private string _author;// private field
        private int _isbn; // private field

        // Title property allows access
        // to the title private field
        public string Title
        {
            get { return _title; }  // get method
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter a number for title");
                }
            }
        }
           
        public string Author
        {
            get { return _author; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter a number for author");
                }
            }
        }

        public int ISBN
        {
            get { return _isbn; }
            set
            {
                if (value.ToString().Any(char.IsDigit))
                {
                    _isbn = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter a letter for ISBN");
                }
            }
                 
            }
                       
        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Method to display information about a book
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}