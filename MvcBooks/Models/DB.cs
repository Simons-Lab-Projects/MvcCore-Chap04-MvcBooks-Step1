using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBooks.Models
{
    public class DB
    {
        public List<Book> books { get; set; }
        public List<Category> cats { get; set; }

        public DB()
        {
            books = new List<Book>();
            books.Add(new Book(1004, 1, "Introduction to .NET", 2012));
            books.Add(new Book(1005, 1, "C# Programming", 2014));
            books.Add(new Book(1006, 1, "VB.NET Programming", 2013));
            books.Add(new Book(1007, 1, "ASP.NET Programming", 2015));
            books.Add(new Book(1008, 2, "Java Programming", 2009));
            books.Add(new Book(1009, 2, "Advanced Java", 2013));
            books.Add(new Book(1010, 2, "JavaServer Pages", 2010));
            books.Add(new Book(1017, 3, "XML Fundamentals", 2012));
            books.Add(new Book(1018, 4, "Introduction to SQL", 2008));

            cats = new List<Category>();
            cats.Add(new Category(1, ".NET"));
            cats.Add(new Category(2, "Java"));
            cats.Add(new Category(3, "XML"));
            cats.Add(new Category(4, "Databases"));
        }
    }
}
