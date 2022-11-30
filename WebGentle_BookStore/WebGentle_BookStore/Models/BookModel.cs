using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebGentle_BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100,MinimumLength =5)]
        [Required(ErrorMessage ="Please enter your Book Title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter Author name")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please enter the Total pages")]
        [Display(Name ="Total Pages of Book")]
        public int? TotalPages { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
    }
}
