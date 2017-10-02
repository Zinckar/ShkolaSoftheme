using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace LibraryAttributes
{
    class Library
    {
        public List<Book> Books;

        public List<User> Users;

        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }


        public bool GiveAwayBook(string name, string author, User user)
        {
            try
            {
                if (ContainsBook(name, author))
                {
                    var book = Books.FirstOrDefault(b => b.Name == name && b.Author == author);
                    if (book != null && book.GetType().GetCustomAttributes(true).FirstOrDefault(attr => attr is OnlyForViewingAttribute) == null)
                    {
                        book.Owner = user;
                        book.ValidateBook();
                        Console.WriteLine($"Book {book.Name} by {book.Author} was given to {user.LastName} {user.FirstName}");
                        return true;
                    }
                    Console.WriteLine("Can't give the book");
                    return false;
                }
                Console.WriteLine("Book not found");
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
        public void BookStats()
        {
       
            Console.WriteLine($"There are {Books.Count} books in library");
            Console.WriteLine($"{Books.Count(b => b is Journal)} of them are Journals");
            Console.WriteLine($"{Books.Count(b => b is RegularBook)} of them are regular books");
           
        }

        public bool ContainsUser(User user)
        {
            if (Users.Any(u => u.LastName == user.LastName && u.Email == user.Email))
            {
                Console.WriteLine("User was found");
                return true;
            }
            else
            {
                Console.WriteLine("User not found");
                return false;
            }

        }

        public bool ContainsBook(string name, string author)
        {
            if (name != null && author != null)
            {
                return Books.Any(b => b.Name == name && b.Author == author);
            }
            else
            {
                return false;
            }

        }
    }
}