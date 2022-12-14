using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int TotalPages { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string CoverImageUrl { get; set; }
        public string BookPdfUrl{ get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        //For One-Many Relationship
        public ICollection<BookGallery> bookGallery { get; set; }
       
    }
    
}
