using Microsoft.AspNetCore.Authorization;
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
                return RedirectToAction("ConfirmEmail", new { email = userModel.Email });
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

        [HttpGet("confirmemail")]
        public async Task<IActionResult> ConfirmEmail(string uid,string token,string email)
        {
            EmailConfirmModel model = new EmailConfirmModel()
            {
                Email = email
            };
            if (!string.IsNullOrEmpty(uid)&&!string.IsNullOrEmpty(token))
            {
                token = token.Replace(' ', '+');   
                var result= await _accountRepository.ConfirmEmailAsync(uid,token);
                if(result.Succeeded)
                {
                    model.EmailVerify = true;
                }
            }
            return View(model);
        }
        [HttpPost("confirmemail")]
        public async Task<IActionResult> ConfirmEmail(EmailConfirmModel emailConfirmModel)
        {
            var user = await _accountRepository.GetUserByEmailAsync(emailConfirmModel.Email);
            if(user != null)
            {
                if(user.EmailConfirmed)
                {
                    emailConfirmModel.EmailVerify = true;
                    return View();
                }
                 await _accountRepository.GenerateEmailConfirmationtokenasync(user);
                emailConfirmModel.EmailSent = true;
                ModelState.Clear();
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong");
            }
            return View(emailConfirmModel);
        }

        [AllowAnonymous,HttpGet("forgotpassword")]
        public IActionResult ForgotPassword()
        {
            return View();

        }
        [AllowAnonymous, HttpPost("forgotpassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            if(ModelState.IsValid)
            {

                var user = await _accountRepository.GetUserByEmailAsync(forgotPasswordModel.Email);
                if(user!=null)
                {
                    await _accountRepository.GenerateForgotPasswordsync(user);
                }

                ModelState.Clear();
                forgotPasswordModel.EmailSent = true;
            }
            return View(forgotPasswordModel);

        }

        [AllowAnonymous, HttpGet("resetpassword")]
        public IActionResult ResetPassword(string uid, string token)
        {
            ResetPasswordModel resetPasswordModel = new ResetPasswordModel()
            {
                UserId=uid,
                Token=token
            };
            return View(resetPasswordModel);

        }
        [AllowAnonymous, HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if (ModelState.IsValid)
            {
                resetPasswordModel.Token = resetPasswordModel.Token.Replace(' ', '+');
                var result =await  _accountRepository.ResetPasswordAsync(resetPasswordModel);
                if(result.Succeeded)
                {
                    ModelState.Clear();
                    resetPasswordModel.IsSuccess = true;
                    return View(resetPasswordModel);
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
               
            }
            return View(resetPasswordModel);

        }

    }
}
