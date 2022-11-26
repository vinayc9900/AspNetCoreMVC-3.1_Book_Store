using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {                                               // Note: In URL Method Names, parameter names are NOT CASE SESITIVE
            //http://localhost:58860/book/getAllbooks      {controller}/{Method}
            return "All Books";
        }
        public string GetBook(int id)
        {
            //http://localhost:58860/book/getbook/2      {controller}/{Method}/{id}
            return $"Book Id ={id}";
        }
        public string SearchBooks(string bookName, string authorName)
        {
            //  http://localhost:58860/book/searchbooks?bookName=java&authorName=pqr   {controller}/{Method}?bookName=value&authorName=value
            return $"Book Name={bookName} and Author Name={authorName}";
        }
    }
}
