using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }


        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }
        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUserModel userModel)
        {
            if(ModelState.IsValid)
            {

                var result =await _accountRepository.CreateUserAsync(userModel);
                if(!result.Succeeded)
                {
                    foreach(var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("",errorMessage.Description);
                    }
                    return View(userModel);
                }
                ModelState.Clear();
            } 
            return View();
        }
        [Route("login")]
        public IActionResult LogIn()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LogIn(SignInModel signInModel, string returnUrl)
        {
            if(ModelState.IsValid)
            {
              var result= await  _accountRepository.PasswordSignInAsync(signInModel);
                if(result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                if(result.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Not Allowed to Login");
                }
               
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                }
            }
            return View();
        }

        [Route("logout")]
        public async Task<IActionResult> LogOut()
        {
            await _accountRepository.SignOutasync();
            return RedirectToAction("Index", "Home");
        }

        [Route("changepassword")]
        public  IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel changePasswordModel)
        {

            if(ModelState.IsValid)
            {
                var result =await _accountRepository.ChangePasswordAsync(changePasswordModel);
                if(result.Succeeded)
                {
                    ViewBag.isSuccess = true;
                    ModelState.Clear();
                    return View();
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(changePasswordModel);
        }
    }
}
