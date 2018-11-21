using Libary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Models
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string interested { get; set; }
        private List<Book> Books = new List<Book>();
        private Library _currentLibrary;


        public void EntersTheBuilding(Library library)
        {
            _currentLibrary = library;
            Console.WriteLine($"{Name} has entered the {library}");
        }

        public void LeftTheBuilding()
        {
            Console.WriteLine($"{Name} has left the building");
        }
    }
}
