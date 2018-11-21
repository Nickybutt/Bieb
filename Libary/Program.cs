using Libary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library() {};

            var nick = new Person() { Name = "Nick", age = 28, interested = "Thriller" };
            nick.EntersTheBuilding(library);
            Console.ReadLine();
        }
    }
}
