namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book : IComparable<Book>
    {
        private readonly string _title;
        private readonly int _year;
        private readonly List<string> _authors;
        //public string Title => _title;
        public string Title { get { return _title; } }
        public int Year => _year;
        public List<string> Authors => this._authors;

        public Book(string title, int year, params string[] authors)
        {
            this._title = title;
            this._year = year;
            this._authors = new List<string>(authors);
        }

        public int CompareTo(Book? other)
        {
            if (other is null) return -1;

            int yearComperison = this._year.CompareTo(other._year);
            if (yearComperison != 0) return yearComperison;

            int titleOfComperison = this._title.CompareTo(other._title);
            return titleOfComperison;
        }

        public string ToString() => $"{this.Title} - {this.Year}";
        
    }
}
