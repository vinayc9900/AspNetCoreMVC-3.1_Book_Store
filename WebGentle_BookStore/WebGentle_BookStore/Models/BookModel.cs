using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebGentle_BookStore.Enums;
using WebGentle_BookStore.Data;
using WebGentle_BookStore.Helpers;
using Microsoft.AspNetCore.Http;

namespace WebGentle_BookStore.Models
{
    public class BookModel
    {
        //[DataType(DataType.DateTime)] // Try other Data types like Date,EmailAddress etc
        //[Display(Name ="Choose the Date and Time")]
        //public string MyField { get; set; }
        public int Id { get; set; }

        // [MyCustomValidationAttribute]
        //[MyCustomValidationAttribute("mvc")]
        // [MyCustomValidationAttribute(ErrorMessage ="This is Custom error validation message")]
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter your Book Title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter Author name")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength = 20)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please enter the Total pages")]
        [Display(Name ="Total Pages of Book")]
        public int? TotalPages { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Please select Language for your Book")]
        public string Language { get; set; }

        [Display(Name ="Choose the cover photo of your book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }//Single Image upload
        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the Gallery images of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; } //Multiple Image upload
        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload your Book in Pdf format")]
        [Required]
        public IFormFile BookPdf { get; set; }//Single Image upload
        public string BookPdfUrl { get; set; }




        //[Required(ErrorMessage = "Please select Laguage for your Book")]
        //public EnumLanguage EnumLanguage { get; set; }

        //[Required(ErrorMessage = "Please select Laguages for your Book")]
        //public List<string> MultiLanguage { get; set; }
    }
}
