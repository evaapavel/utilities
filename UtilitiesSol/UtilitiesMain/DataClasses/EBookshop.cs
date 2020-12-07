using System;
using System.Collections.Generic;



namespace UtilitiesMain.DataClasses
{
    public class EBookshop
    {

        //List<T>

        public string url;
        //public Book[] books;
        public List<Book> books;

        public EBookshop(string url)
        {
            this.url = url;
            this.books = new List<Book>();
        }

    }
}
