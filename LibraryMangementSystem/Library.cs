using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem
{
    internal class Library
    {
        List<Book> books = new List<Book>();


        public void AddBook()
        {
            Console.WriteLine("Enter the title of the Book is : ");
            string title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Author of the Book is : ");
            string author = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("Enter the Genre of the Book: ");
            string genre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the Book : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(title, author, genre, quantity);
            books.Add(book);

        }
        public void DisplayItems()
        {
            foreach (Book book in books)
            {
                book.Display_books();
            }
        }
        public void FindBooks(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($"{title} is present in this library");
                    return;
                }
            }
            Console.WriteLine($"{title} is not present in this library");
        }
    }
}
