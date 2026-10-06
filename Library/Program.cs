using Library;

Book book = new Book();

// This is info for the book class
book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN = "12345678";

book.DisplayInfo();

// This is another book in our library
Book book1 = new Book();
book1.Title = "C# for Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667788";

book1.DisplayInfo();