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
