using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        //use IdentityUser for Default 
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountRepository(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            //  var user = new IdentityUser() for Default Identity
            var user = new ApplicationUser()
            {
                FirstName=userModel.FirstName,
                LastName=userModel.LastName,
                Email = userModel.Email,
                UserName=userModel.Email
            };

          var result= await  _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
          var result= await  _signInManager.PasswordSignInAsync(signInModel.Email,signInModel.Password,signInModel.RememberMe,false);
            return result;
        }
        public async Task SignOutasync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
