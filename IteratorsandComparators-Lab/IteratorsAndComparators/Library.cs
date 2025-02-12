namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Задача 1 & 2 + IEnumerable изписване дълъг начин
    //public class Library : IEnumerable<Book>
    //{
    //    private readonly List<Book> books;

    //    public List<Book> Books => books;

    //    public Library(params Book[] books)
    //    {
    //        this.books = new List<Book>(books);
    //    }

    //    public IEnumerator<Book> GetEnumerator() => new LibraryIterator(this.books);


    //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    //    private class LibraryIterator : IEnumerator<Book>
    //    {
    //        private List<Book> Books;
    //        private int index;

    //        public LibraryIterator(List<Book> books)
    //        {
    //            this.Books = books;
    //            this.Reset();
    //        }
    //        public Book Current => this.Books[this.index];

    //        object IEnumerator.Current => this.Current;

    //        public bool MoveNext()
    //        {
    //            if (this.index >= Books.Count)
    //            {
    //                return false;
    //            }
    //                return ++this.index < this.Books.Count;
    //        }

    //        public void Reset()
    //        {
    //            this.index = -1;
    //        }

    //        public void Dispose()
    //        {
    //        }
    //    }
    //}

    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public List<Book> Books => this.books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books.OrderBy(b => b));
            //this.books.Sort();
        }

        public IEnumerator<Book> GetEnumerator() => this.books.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
