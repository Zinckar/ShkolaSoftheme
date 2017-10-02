using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAttributes
{
    class RegularBook : Book
    {
        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Annotation of Book can be between 1 and 255 digits")]
        public string Annotation { get; set; }
    }
}
