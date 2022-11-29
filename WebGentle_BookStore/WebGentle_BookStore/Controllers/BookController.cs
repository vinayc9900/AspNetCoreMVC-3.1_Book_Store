using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;
        [ViewData]  //View Data Attribute
        public string Title { get; set; }
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            Title = "All Books";
            // Note: In URL Method Names, parameter names are NOT CASE SESITIVE
            //http://localhost:58860/book/getAllbooks      {controller}/{Method}
            var data=_bookRepository.GetAllBooks();

         
            return View(data);
            
        }
        [Route("book-details/{id}",Name="bookDetailsRoute")] 
        public ViewResult GetBook(int id)
        {   

           
            //http://localhost:58860/book/getbook/2  {controller}/{Method}/{id}
            var data = _bookRepository.BookById(id);
            Title = "Book Info- " + data.Title;
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            //  http://localhost:58860/book/searchbooks?bookName=Mvc&authorName=Nitish   {controller}/{Method}?bookName=value&authorName=value
            return _bookRepository.SearchBooks(bookName, authorName);
        }
        public ViewResult AddNewBook()
        {
            Title = "Add Book";
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookmodel)
        {
          
            return View();
        }

    }
}
