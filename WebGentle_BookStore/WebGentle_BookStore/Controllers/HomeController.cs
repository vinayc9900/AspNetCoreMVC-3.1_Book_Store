using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Controllers
{
    public class HomeController:Controller
    { 
        [ViewData]  //View Data Attribute
        public string bookName { get; set; }
        [ViewData]  //View Data Attribute
        public string Title { get; set; }
        [ViewData]  //View Data Attribute
        public BookModel Book { get; set; }
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

        public ViewResult AboutUs()
        {
            ViewData["FillName"] = "Anilkumar P";
            // ViewData["Book"] = new BookModel() { Author = "Ashish", Id = 22 };
            Book = new BookModel() { Id = 345, Author = "abhi" }; // Using [ViewData] Attribute
            Title= "About Us";
            return View();
        }
        public ViewResult ContactUs()
        {
            bookName = "Narnia 2"; // Assignig value to ViewData Property
            Title = "Contact Us";
            return View();
        }
    }
}
