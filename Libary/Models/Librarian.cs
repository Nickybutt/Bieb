using Libary.Enums;
using Libary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Models
{
    class Librarian : ILibrarian
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string WorkAttitude { get; set; }
        public string Strictness { get; set; }
        public bool LibrarianIsAvailable { get; set; }

        private List<IBook> Books = new List<IBook>();


        public void ListOfBooks()
        {
            int numberOfBooks = 0;
            foreach (Book Book in Books)
            {
                if (Book.IsAvailable == true)
                {
                    numberOfBooks = numberOfBooks + 1;
                    Console.WriteLine(Book.Title);
                }
            }
            Console.WriteLine($"there are {numberOfBooks} books in the library");
        }
    }
}
