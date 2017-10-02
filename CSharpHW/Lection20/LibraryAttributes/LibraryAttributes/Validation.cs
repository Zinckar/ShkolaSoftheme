using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAttributes
{
    static class Validation
    {
        public static void ValidateBook(this Book book)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(book);
            if (!Validator.TryValidateObject(book, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                throw new ArgumentException();
            }
            Console.WriteLine($"'{book.Name}' by {book.Author} is Ok" );
        }

        public static bool ValidateUser(this User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            Console.WriteLine($"User '{user.LastName}' is Ok");
            return true;
        }
    }
}
