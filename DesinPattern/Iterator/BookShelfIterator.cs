using System;
using System.Linq;

namespace DesinPattern.Iterator
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        public bool hasNext()
        {
            if (index < bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loop()
        {
            var books = bookShelf.GetBooks();
            books.ForEach(x => Console.WriteLine(x.GetName()));
        }

        public object next()
        {
            var book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}