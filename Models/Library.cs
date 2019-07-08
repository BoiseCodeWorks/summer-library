using System;
using System.Collections.Generic;

namespace library.Models
{
    class Library
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        private List<Publication> AvailableBooks { get; set; }
        public List<Publication> CheckedOutBooks { get; set; }
        public void AddBook(Book bookToAdd)
        {
            AvailableBooks.Add(bookToAdd);
        }
        public void RemoveBook(Book bookToRemove)
        {
            AvailableBooks.Remove(bookToRemove);
        }
        public void PrintAvailableBooks()
        {
            int num = 1;
            System.Console.WriteLine("Available Books:");
            foreach (var book in AvailableBooks)
            {
                System.Console.WriteLine($"{num}) {book.Title}");
                num++;
            }
            System.Console.WriteLine("Please Select a number to Check a book out or type 'return' to see books to return: ");
        }

        public void PrintAvailableBooks(int index)
        {
            System.Console.WriteLine(AvailableBooks[index].Title);
        }
        public void PrintAvailableBooks(string index)
        {
            System.Console.WriteLine(AvailableBooks[Int32.Parse(index)].Title);
        }

        public void PrintCheckedOutBooks()
        {
            int num = 1;
            System.Console.WriteLine("Checked out Books:");
            foreach (var book in CheckedOutBooks)
            {
                System.Console.WriteLine($"{num}) {book.Title}");
                num++;
            }
            System.Console.WriteLine("Please Select a number to Return a book or type 'available' to see books to checkout: ");
        }
        public void CheckoutBook(string selection)
        {
            Console.Clear();
            Publication book = ValidateSelection(selection, AvailableBooks);
            if (book != null)
            {
                book.Available = false;
                CheckedOutBooks.Add(book);
                AvailableBooks.Remove(book);
                System.Console.WriteLine($"enjoy your book {book.Title}");
                return;
            }
            Console.WriteLine("Invalid Selection");
        }



        public void ReturnBook(string selection)
        {
            Console.Clear();
            Publication book = ValidateSelection(selection, CheckedOutBooks);
            if (book != null)
            {
                book.Available = true;
                CheckedOutBooks.Remove(book);
                AvailableBooks.Add(book);
                System.Console.WriteLine($"Thank you for returning {book.Title}");
                return;
            }
            Console.WriteLine("Invalid Selection");
        }

        public Publication ValidateSelection(string selection, List<Publication> books)
        {
            if (Int32.TryParse(selection, out int index))
            {
                index--;
                //check if that is an index in the Available books
                if (index > -1 && index < books.Count)
                {
                    return books[index];
                }
            }
            return null;
        }

        public Library(string name, string location)
        {
            Name = name;
            Location = location;
            AvailableBooks = new List<Publication>(); //instantiate any list/dictionary inside the ctor
            CheckedOutBooks = new List<Publication>();
        }
    }
}


