using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel changePModel);
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task GenerateEmailConfirmationtokenasync(ApplicationUser user);
        Task GenerateForgotPasswordsync(ApplicationUser user);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        Task SignOutasync();
    }
}