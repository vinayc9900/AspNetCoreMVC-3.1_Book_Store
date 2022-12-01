using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Data;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Books() {

                Author = bookModel.Author,
                Title = bookModel.Title,
                Description = bookModel.Description,
                TotalPages = bookModel.TotalPages.HasValue ? bookModel.TotalPages.Value : 0,
                Category = bookModel.Category,
                Language=bookModel.Language,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
               
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;

        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
           
            var allbooks = await _context.Books.ToListAsync();
            if(allbooks?.Any()==true)
            {
                foreach(var b in allbooks)
                {   // convert db data to Bookmodel
                    books.Add(new BookModel()
                    {
                        Author = b.Author,
                        Category=b.Category,
                        Description=b.Description,
                        Id=b.Id,
                        Language=b.Language,
                        Title=b.Title,
                        TotalPages=b.TotalPages
                    });
                }
            }
            return books;
        }
        public async Task<BookModel> BookById(int id)
        {
            var book =await  _context.Books.FindAsync(id);
            //_context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(book!=null)
            {
                var bookDetails = new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    Language = book.Language,
                    Title = book.Title,
                    TotalPages = book.TotalPages
                };
                return bookDetails;
            }
            return null;
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel()  {Id=1,Title= "MVC",Author="Vinay",Description="Description for MVC Concept",Category="Framework",TotalPages=1031,Language="English"},
                new BookModel() { Id = 2, Title = "Java", Author = "Nitish",Description="Description for JAVA Concept",Category="Programming",TotalPages=855,Language="English" },
                new BookModel() { Id = 3, Title = "ASP", Author = "Vijay" ,Description="Description for ASP Concept",Category="Framework",TotalPages=110,Language="English"},
                new BookModel() { Id = 4, Title = "Selenium", Author = "Raju",Description="Description for SELENIUM Concept",Category="Testing",TotalPages=980,Language="English" },
                new BookModel() { Id = 5, Title = "C++", Author = "Sanjay",Description="Description for C++ Concept",Category="Programming",TotalPages=1056,Language="English" },
                 new BookModel() { Id = 6, Title = "DevOps", Author = "Sanjay",Description="Description for DevOps Concept",Category="Software",TotalPages=1087,Language="English" }
            };
        }

        internal int BookById()
        {
            throw new NotImplementedException();
        }

        internal List<BookModel> SearchBook()
        {
            throw new NotImplementedException();
        }
    }
}
