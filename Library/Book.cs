using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private int _isbn;

        // Public properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        
        // Constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            _title = bookTitle;
            _author = bookAuthor;
            _isbn = bookISBN;
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