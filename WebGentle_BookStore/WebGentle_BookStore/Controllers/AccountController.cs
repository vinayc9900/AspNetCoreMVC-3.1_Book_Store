﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
