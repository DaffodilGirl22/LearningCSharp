using System;

namespace LearningCSharp
{
    class Book
    {
        // A template for a book
        public string title;
        public string author;
        public int pages;

        // The Constructor - always called when creating a new "Book"
        public Book()
        {
            Console.WriteLine("Creating book ...");
        }
    }
}
