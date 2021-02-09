using System;
using System.Collections.Generic;

namespace DesinPattern.Iterator
{
    public class BookShelf : Aggregate
    {
        private List<Book> books;

        public BookShelf()
        {
            this.books = new List<Book>();
        }

        public Book GetBookAt(int index)
        {
            return books[index];
        }

        public void AppendBook(Book book)
        {
            books.Add(book);
        }

        public int GetLength()
        {
            return books.Count;
        }

        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
