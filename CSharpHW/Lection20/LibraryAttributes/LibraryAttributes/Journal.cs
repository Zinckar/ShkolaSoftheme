using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAttributes
{
    [OnlyForViewing]
    public class Journal : Book
    {
        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "ImageUrl can be between 1 and 255 digits")]
        public string ImgUrl { get; set; }
    }
}