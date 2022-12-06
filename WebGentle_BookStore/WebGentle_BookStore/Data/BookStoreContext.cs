using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Data
{
    // : IdentityDbContext  it isfor Default Identity to Inherit
    public class BookStoreContext:IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookGallery> BookGallery { get; set; }

    }
}
