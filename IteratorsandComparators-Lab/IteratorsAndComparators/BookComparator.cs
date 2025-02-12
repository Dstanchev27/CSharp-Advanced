namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return 1;
            if (y is null) return -1;

            int titleComperison = string.Compare(x.Title, y.Title);
            if (titleComperison != 0) return titleComperison;

            int yearComperison = -1 * Comparer<int>.Default.Compare(x.Year, y.Year);
            return yearComperison;
        }
    }
}
