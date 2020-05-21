using System;

namespace LearningCSharp
{
    class NewBook
    {
        // A template of attributes for a NewBook
        public string title;
        public string author;
        public int pages;

        // A constructor method is always called when creating a new "Book"
        // Constructor with no parameters
        public NewBook()
        {
        }

        // Constructor with parameters
        public NewBook(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
