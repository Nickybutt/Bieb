using Libary.Enums;
using Libary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Models
{
    public class Book : IBook
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public BookType Genre { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string name, string author, int pages, string isbn, BookType genre, bool isAvailable)
        {
            string Name = name;
            string Author = author;
            int Pages = pages;
            string ISBN = isbn;
            BookType Genre = genre;
            bool IsAvailable = isAvailable;
        }

        public Book(string name, string author, int pages, string isbn, BookType genre)
        {
            string Name = name;
            string Author = author;
            int Pages = pages;
            string ISBN = isbn;
            BookType Genre = genre;
        }
    }

}
