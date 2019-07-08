using System;
using library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region CREATE DATA
            Library adaLib = new Library("Library!", "Downtown Boise, ID");
            Book hp = new Book("Harry Potter and the Goblet of Fire", 757, "JK Rowling");
            Book theBigShort = new Book("The Big Short", 357, "Michael Lewis");
            Book narnia = new Book("The Lion the Witch and the Wardrobe", 645, "CS Lewis");
            Book sidewalk = new Book("Where the Sidewalk Ends", 918, "Shel Silverstein");
            adaLib.AddBook(hp);
            adaLib.AddBook(theBigShort);
            adaLib.AddBook(narnia);
            adaLib.AddBook(sidewalk);

            Magazine time1 = new Magazine("Time", 23, 54, "Person of the Year");

            adaLib.AddBook(time1);






            #endregion
            bool inLibrary = true;
            string menu = "available";

            while (inLibrary)
            {
                //which list of books to print
                switch (menu)
                {
                    case "available":
                        adaLib.PrintAvailableBooks();
                        break;
                    case "return":
                        adaLib.PrintCheckedOutBooks();
                        break;
                }
                string selection = Console.ReadLine().ToLower();

                //determines if need to change active menu
                if (selection == "return")
                {
                    Console.Clear();
                    menu = "return";
                    continue;
                }
                if (selection == "available")
                {
                    Console.Clear();
                    menu = "available";
                    continue;
                }

                //This switch handles either returning or checking out a book
                switch (menu)
                {
                    case "available":
                        adaLib.CheckoutBook(selection);
                        break;
                    case "return":
                        adaLib.ReturnBook(selection);
                        break;
                }
            }
        }
    }
}
