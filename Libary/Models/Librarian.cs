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
        List<Book> Books = new List<Book>();


        public void ListOfBooks()
        {
            int numberOfBooks = 0;
            foreach (var Book in Books)
            {
                numberOfBooks =+ 1;
            }
            Console.WriteLine($"there are {numberOfBooks} in the library");
        }

        public void AddSomeBooks()
        {
            Books.Add(new Book("A game of thrones", "George R.R. Martin", 789, "4564654", BookType.Fantasy));
            Books.Add(new Book("A clash of kings", "George R.R. Martin", 789, "46548", BookType.Fantasy));
            Books.Add(new Book("A feast for crows", "George R.R. Martin", 789, "456386", BookType.Fantasy));
            Books.Add(new Book("A storm of swords", "George R.R. Martin", 789, "563159", BookType.Fantasy));
            Books.Add(new Book("A dance with dragons", "George R.R. Martin", 789, "54626", BookType.Fantasy));
            Books.Add(new Book("it", "Stephen King", 1041, "98651616", BookType.Horror));
            Books.Add(new Book("Fifty shades of shit", "lucas", 9, "5465123", BookType.Fantasy));

        }


        
    }
}
