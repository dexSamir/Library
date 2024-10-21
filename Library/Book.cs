using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Price: {Price} Author: {Author} Genre:{Genre}\n");
        }
        public Book(string name, double price, string author, string genre)
        {
            Name = name;
            Price = price;  
            Genre = genre;  
            Author = author;
        }
    }
}
