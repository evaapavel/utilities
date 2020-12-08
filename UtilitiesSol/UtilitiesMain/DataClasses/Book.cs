using System;

namespace UtilitiesMain.DataClasses
{


    public class Book
    {
        public string title;
        public int publishedIn;
        public Person author;
        public Publisher publisher;

        public Book()
        {
        }

        public Book(string title, int publishedIn, Person author, Publisher publisher)
        {
            this.title = title;
            this.publishedIn = publishedIn;
            this.author = author;
            this.publisher = publisher;
        }
    }


}
