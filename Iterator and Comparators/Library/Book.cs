﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public List<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public int CompareTo(Book otherBook)
        {
            if (this.Year > otherBook.Year)
            {
                return 1;
            }

            else if (this.Year == otherBook.Year)
            {
                return this.Title.CompareTo(otherBook.Title);
            }

            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
