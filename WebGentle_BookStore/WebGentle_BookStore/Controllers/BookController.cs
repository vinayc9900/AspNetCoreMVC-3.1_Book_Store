﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            Title = "All Books";
            // Note: In URL Method Names, parameter names are NOT CASE SESITIVE
            //http://localhost:58860/book/getAllbooks      {controller}/{Method}
            var data=await _bookRepository.GetAllBooks();

         
            return View(data);
            
        }
        [Route("book-details/{id}",Name="bookDetailsRoute")] 
        public async Task<ViewResult> GetBook(int id)
        {   

           
            //http://localhost:58860/book/getbook/2  {controller}/{Method}/{id}
            var data = await _bookRepository.BookById(id);
            Title = "Book Info- " + data.Title;
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            //  http://localhost:58860/book/searchbooks?bookName=Mvc&authorName=Nitish   {controller}/{Method}?bookName=value&authorName=value
            return _bookRepository.SearchBooks(bookName, authorName);
        }
        public ViewResult AddNewBook(bool isSuccess=false,int bookId=0)
        {
            //// For Dropdown default selection Pass the model in view
            var model = new BookModel()
            {
                //Language = "English"
               // Language="2"  // It is for LanguageModel class selectListItem by Id 

            };

            //Addig List to <Select> from Controller
            //ViewBag.Language = new SelectList(new List<string>() {"English","Kannada","Hindi"});
            //ViewBag.Language = new SelectList(getLanguage(), "Id", "Text");

            //ViewBag.Language = getLanguage().Select(x => new SelectListItem()
            //{

            //    Text = x.Text,
            //    Value=x.Id.ToString()

            //}).ToList();

            ViewBag.Language = getLanguage1();

            ViewBag.isSuccess = isSuccess;
            ViewBag.bookId = bookId; 
            Title = "Add Book";
            return View(model); 
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookmodel)
        {
           if(ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookmodel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            // ViewBag.Language = new SelectList(new List<string>() { "English", "Kannada", "Hindi" });
            //ViewBag.Language = new SelectList(getLanguage(), "Id", "Text");
            ViewBag.Language = getLanguage1();
            ModelState.AddModelError("", "This is my Custom error message"); // it Displays along with Validation summary
            return View();
        }

        private List<LanguageModel> getLanguage() 
        {
        
        return new List<LanguageModel>(){

                new LanguageModel() { Id=1,Text="Hindi"},
                new LanguageModel() { Id = 2, Text = "English" },
                new LanguageModel() { Id = 3, Text = "Kannada" },
                new LanguageModel() { Id = 4, Text = "French" }
            };
        }

        private List<SelectListItem> getLanguage1()
        {
            return new List<SelectListItem>() {
                new SelectListItem(){Text="Hindi",Value="1"},
                 new SelectListItem(){Text="English",Value="2",Disabled=true},
                  new SelectListItem(){Text="Kannada",Value="3"},
                   new SelectListItem(){Text="French",Value="4",Selected=true}
            };
           
        }

    }
}
