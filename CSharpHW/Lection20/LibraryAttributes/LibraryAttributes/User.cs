using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAttributes
{
    public class User
    {
        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "First name should be between 2 and 255 digits")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name should constain only letters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name should constain only letters")]
        public string LastName { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
}

