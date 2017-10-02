//using System;
//using System.Runtime.InteropServices;

//namespace Library
//{
//    class Program
//    {
//        static void Main()
//        {
//            var library = new Library();

//            ShowLibraryInfo(library);

//            library[0] = new Book("Interesting book");

//            ShowLibraryInfo(library);

//            Console.ReadLine();
//        }

//        private static void ShowLibraryInfo(Library library)
//        {
//            Console.WriteLine("Library contains {0} books.", library.Length);
//            for (var i = 0; i < library.Length; i++)
//            {
//                Book currentBook = library[i];
//                Console.WriteLine(currentBook.Name);
//            }
//            foreach (var book in library)
//            {
//                Console.WriteLine(((Book)book).Name);
//            }
//            Console.WriteLine();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
     


            var library = new Library();
            AddBooks(library);
            AddUsers(library);
    
            Authentification(library);
          
            library.BookStats();
            Console.ReadKey();
        }
        private static void AddUsers(Library library)
            {
                library.Users.AddRange(new List<User>
                {
                    new User {LastName = "Zhakobin", FirstName ="Zhakobin", Email = "Abrakadabra@gmail.com"},
                    new User {LastName = "Pablo", FirstName = "Huano", Email = "cookiea@gmail.com"},
                    new User {LastName = "Tesla", FirstName = "Nicola", Email = "wtf@gmail.com"},
                   
                });
            }

            private static void AddBooks(Library library)
            {
                library.Books.AddRange(new List<Book>
                {
                    new RegularBook { Name = "1984", Author = "Notme", Annotation = "Good stuff" },
                    new RegularBook { Name = "Lol", Author = "Memgenerator", Annotation = "kappaPride" },
                    new Journal   { Name = "IDK", Author = "Myfriend", ImgUrl = "www.awesomecookies.com" },
                    
                });
            }
        private static User Authentification(Library library)
        {
            User user;
            do
            {
                Console.WriteLine("Log in or Register:");
                Console.Write("Name: ");
                var userName = Console.ReadLine();

                Console.Write("Last name: ");
                var userLastName = Console.ReadLine();

                Console.Write("Email: ");
                var email = Console.ReadLine();
                user = new User { FirstName = userName, LastName =  userLastName, Email = email };
                library.Users.Add(user);
                library.GiveAwayBook("1984", "Notme", user);
                library.GiveAwayBook("IDK", "Myfriend", user);
            }
            while (!user.ValidateUser() || !library.ContainsUser(user));
            return user;
        }
    }
   
}