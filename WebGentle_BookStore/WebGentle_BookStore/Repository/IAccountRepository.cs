using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel changePModel);
        Task SignOutasync();
    }
}