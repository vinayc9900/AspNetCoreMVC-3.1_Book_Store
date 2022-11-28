using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            var obj = new { Id = 1, Name = "Vinay" };
            // View Name is Index.cshtml & Method name is also Index() so no need to pass anything in View()
            return View();// Default Returns Index View
            //return View("AboutUs"); //Returning Different View 
            //return View(obj);// Passing Object With Same View
            //return View("AboutUS", obj);//Passing Object with Different View
            //return View("~/TempView/TempVinay.cshtml"); //Passing ViewPath which Exist in Diffrent Location
            //return View("../../TempView/TempVinay");// From Current Position to Root Directory using "Relative Path"
        }

        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
