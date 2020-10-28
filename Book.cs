using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    // A class is a blueprint/specification to represent an entity 
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // CONSTRUCTOR - A method that will be called when we create an instance of said class
        public Book()
        {
            // Takes no parameters
        }
        
        // We can have more than 1 constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book");
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        // OBJECT METHODS - A book with 500 pages or more is considered thick
        public bool ThickBook()
        {
            if (pages >= 500)
            {
                return true;
            }
            return false;
        }
    }
}
