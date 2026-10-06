using System;
using System.Linq;

namespace Library
{
    public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private string _isbn; // Changed from int to string

        // Public properties
        public string Title
        {
            get { return _title; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Error: Cannot enter number for title.");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return _isbn; } // Fixed: Use backing field
            set
            {
                // Fixed: Better validation for null or empty spaces
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _isbn = value; // Fixed: Use backing field
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // Constructor
        // Fixed: bookISBN parameter changed to string to match the property
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Methods 
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}