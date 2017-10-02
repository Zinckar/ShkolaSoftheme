using System.ComponentModel.DataAnnotations;

namespace LibraryAttributes
{
    public abstract class Book
    {
        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Book's name can be between 1 and 255 digits")]
        public string Name { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Author's name can be between 1 and 255 digits")]
        public string Author { get; set; }

        public User Owner { get; set; }
    }
}