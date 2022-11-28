using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel>GetAllBooks()
        {
            return DataSource();
        }
        public BookModel BookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel()  {Id=1,Title= "Mvc",Author="Vinay"},
                new BookModel() { Id = 2, Title = "Java", Author = "Nitish" },
                new BookModel() { Id = 3, Title = "ASP", Author = "Vijay" },
                new BookModel() { Id = 4, Title = "Selenium", Author = "Raju" },
                new BookModel() { Id = 5, Title = "C++", Author = "Sanjay" }
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
