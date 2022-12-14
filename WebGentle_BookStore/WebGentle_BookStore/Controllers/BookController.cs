using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore.Controllers
{
    //[Route("[controller]/[action]")] // i.e Home/Index
                                      // i.e Home/AboutUs
                                     // i.e Home/ContactUs
    public class BookController : Controller
    {
       // private readonly BookRepository _bookRepository=null;
        private readonly IBookRepository _bookRepository = null;
        private readonly IWebHostEnvironment _webhostEnvironment;
        [ViewData]  //View Data Attribute
        public string Title { get; set; }  
        public BookController(IBookRepository bookRepository, IWebHostEnvironment webHostEnvironment)
        {
            _bookRepository = bookRepository;
            _webhostEnvironment = webHostEnvironment;// for server path
        }
       // [Route("~/allbooks")]  // ~/ will be used to override Prev/Existing Route
        [Route("allbooks")]
        public async Task<ViewResult> GetAllBooks()
        {
            Title = "All Books";
            // Note: In URL Method Names, parameter names are NOT CASE SESITIVE
            //http://localhost:58860/book/getAllbooks      {controller}/{Method}
            var data=await _bookRepository.GetAllBooks();

         
            return View(data);
            
        }

        // [Route("~/book-details/{id:int}",Name ="bookDetailsRoute")] // with Constraints [id:int]
        [Route("book-details/{id:int:min(1)}", Name = "bookDetailsRoute")]
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
        [Authorize] //Only Loged in user can access this View
        [Route("addnewbook")]
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

            //ViewBag.Language = getLanguage1();

            ViewBag.isSuccess = isSuccess;
            ViewBag.bookId = bookId; 
            Title = "Add Book";
            return View(model); //pass model to select default value for selectList & selectListItem
        }
      
        
        [HttpPost]

        public async Task<IActionResult> AddNewBook(BookModel bookmodel)
        {
            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                if(bookmodel.CoverPhoto!=null)
                {
                    string folder = "books/cover/";
                    bookmodel.CoverImageUrl= await UploadImage(folder, bookmodel.CoverPhoto);

                }
                if (bookmodel.GalleryFiles != null)
                {
                    string folder = "books/gallery/";
                    bookmodel.Gallery = new List<GalleryModel>();

                    foreach(var file in bookmodel.GalleryFiles)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name = file.FileName,
                            Url = await UploadImage(folder,file)
                        };
                        bookmodel.Gallery.Add(gallery);

                    }


                }

                if (bookmodel.BookPdf != null)
                {
                    string folder = "books/pdf/";
                    bookmodel.BookPdfUrl = await UploadImage(folder, bookmodel.BookPdf);

                }
                int id = await _bookRepository.AddNewBook(bookmodel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
               
            }

            // ViewBag.Language = new SelectList(new List<string>() { "English", "Kannada", "Hindi" });
            //ViewBag.Language = new SelectList(getLanguage(), "Id", "Text");
            //ViewBag.Language = getLanguage1();

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
            // Use Grouping
            //var group1 = new SelectListGroup() { Name = "Group1" };
            //var group2 = new SelectListGroup() { Name = "Group2" };
            //var group3 = new SelectListGroup() { Name = "Group3", Disabled = true };

            //return new List<SelectListItem>() {
            //    new SelectListItem(){Text="Hindi",Value="1",Group=group1},
            //     new SelectListItem(){Text="English",Value="2",Group=group1},
            //      new SelectListItem(){Text="Kannada",Value="3",Group=group2,Selected=true},
            //       new SelectListItem(){Text="French",Value="4",Group=group2},
            //         new SelectListItem(){Text="Telugu",Value="5",Group=group3},
            //       new SelectListItem(){Text="Tamil",Value="6",Group=group3}
            //};
            return new List<SelectListItem>() {
                new SelectListItem(){Text="Hindi",Value="1"},
                 new SelectListItem(){Text="English",Value="2",Disabled=true},
                  new SelectListItem(){Text="Kannada",Value="3"},
                   new SelectListItem(){Text="French",Value="4",Selected=true}
            };

        }
        private async Task<string> UploadImage(string folderPath,IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webhostEnvironment.WebRootPath, folderPath);//server path
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }

    }
}
