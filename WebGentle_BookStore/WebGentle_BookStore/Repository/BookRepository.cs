using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Data;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Books()
            {

                Author = bookModel.Author,
                Title = bookModel.Title,
                Description = bookModel.Description,
                TotalPages = bookModel.TotalPages.HasValue ? bookModel.TotalPages.Value : 0,
                Category = bookModel.Category,
                Language = bookModel.Language,
                CoverImageUrl = bookModel.CoverImageUrl,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                BookPdfUrl = bookModel.BookPdfUrl

            };

            newBook.bookGallery = new List<BookGallery>();
            foreach (var file in bookModel.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    Url = file.Url
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;

        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();

            var allbooks = await _context.Books.ToListAsync();
            if (allbooks?.Any() == true)
            {
                foreach (var b in allbooks)
                {   // convert db data to Bookmodel
                    books.Add(new BookModel()
                    {
                        Author = b.Author,
                        Category = b.Category,
                        Description = b.Description,
                        Id = b.Id,
                        Language = b.Language,
                        Title = b.Title,
                        TotalPages = b.TotalPages,
                        CoverImageUrl = b.CoverImageUrl
                    });
                }
            }
            return books;
        }
        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {

            return await _context.Books
                .Select(b => new BookModel()
                {
                    Author = b.Author,
                    Category = b.Category,
                    Description = b.Description,
                    Id = b.Id,
                    Language = b.Language,
                    Title = b.Title,
                    TotalPages = b.TotalPages,
                    CoverImageUrl = b.CoverImageUrl
                }).Take(count).ToListAsync();

        }
        public async Task<BookModel> BookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                return await _context.Books.Where(x => x.Id == id).Select(book => new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    Language = book.Language,
                    Title = book.Title,
                    TotalPages = book.TotalPages,
                    CoverImageUrl = book.CoverImageUrl,
                    Gallery = book.bookGallery.Select(x => new GalleryModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Url = x.Url
                    }).ToList(),
                    BookPdfUrl = book.BookPdfUrl

                }).FirstOrDefaultAsync();
            }
            else
            {
                return null;
            }


        }
        public List<BookModel> SearchBooks(string title, string authorName)
        {
            //return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
            return null;
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
