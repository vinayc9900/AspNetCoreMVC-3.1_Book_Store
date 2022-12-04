using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Controllers
{
   // [Route("[controller]/[action]")] // i.e Home/Index
                                     // i.e Home/AboutUs
                                     // i.e Home/ContactUs
    public class HomeController:Controller
    { 
        [ViewData]  //View Data Attribute
        public string bookName { get; set; }
        [ViewData]  //View Data Attribute
        public string Title { get; set; }
        [ViewData]  //View Data Attribute
        public BookModel Book { get; set; }

        [Route("")]  // will exeute with default controller & view i.e Home/Index
     // [Route("~/")]  use ~/ symbol to override Previous/Existing Route
                     // [Route("[controller]/[action]")]  // use current controller i.e Home/Index
        public ViewResult Index()
        {
            var obj = new { Id = 1, Name = "Vinay" };
            // View Name is Index.cshtml & Method name is also Index() so no need to pass anything in View()
            // Default Returns Index View
                          //return View("AboutUs"); //Returning Different View 
                          //return View(obj);// Passing Object With Same View
                          //return View("AboutUS", obj);//Passing Object with Different View
                          //return View("~/TempView/TempVinay.cshtml"); //Passing ViewPath which Exist in Diffrent Location
                          //return View("../../TempView/TempVinay");// From Current Position to Root Directory using "Relative Path"
            dynamic data = new ExpandoObject();
            data.Id = 123;
            data.Name = "Vinay";
            ViewBag.data = data;

            ViewBag.Title = "Book Store";
            ViewBag.Type = new BookModel() {Id=1, Author="Anil" };
            Title = "Home";
            return View();
        }

        // Attribute Routing

        // [Route("about-us/{id}/{name}")]  //about-us/7/vinay
        // [Route("about-us/{id}/test/{name}")] // about-us/5/test/vinay
       // [Route("about-us")] // about-us?id=3&name=vinay
        // [HttpGet("about-us",Name ="aboutus")]
       // [Route("about-us", Name = "aboutus",Order =1)][HttpGet]
       //[Route("about-us/{name:alpha}")] //accepts only char
        [Route("about-us/{name:alpha:minlength(5)}")] //name minlength should be 5
        public ViewResult AboutUs(string name)
        {
            ViewData["FillName"] = "Anilkumar P";          
           // ViewData["Book"] = new BookModel() { Author = "Ashish", Id = 22 };
            Book = new BookModel() { Id = 345, Author = "abhi" }; // Using [ViewData] Attribute
            Title= "About Us"; 
            return View();   
        }


        // [Route("contact-us")] 
        //[Route("contact-us",Name ="contactus")]
        [Route("test/a{a}")]  //  /test/aVinay
        public ViewResult ContactUs(string a) 
        {
            bookName = "Narnia 2"; // Assignig value to ViewData Property
            Title = "Contact Us";
            return View();
        }
      
    }
}
