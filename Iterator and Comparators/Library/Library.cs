using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
            this.books.Sort(new BookComparator());
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }
            public void Dispose()
            {

            }
            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }
            public void Reset()
            {
                this.currentIndex = -1;
            }
            public Book Current
            {
                get
                {
                    return books[currentIndex];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return books[currentIndex];
                }
            }

        }
    }
}
