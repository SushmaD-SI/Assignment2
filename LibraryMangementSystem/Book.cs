using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem
{
    internal class Book
    {
        private string title;
        private string author;
        private string genre;
        private int quantity;

        public string Title
        {
            get { return title; }
            set { title = value; }

        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Book(string title, string author, string genre, int quantity)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;

        }

        public void Display_books()
        {
            Console.WriteLine("*********** Library Management System **********");
            Console.WriteLine($"The title of the Book is           : {title}");
            Console.WriteLine($"The Author of the Book is          : {Author}");
            Console.WriteLine($"The Genre of the Book is is        : {Genre}");
            Console.WriteLine($"The total Quantity of the books is : {Quantity}");

        }
    }
}
