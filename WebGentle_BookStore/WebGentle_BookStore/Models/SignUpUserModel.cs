using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter your Email")]
        [EmailAddress(ErrorMessage ="please enter valid Email")]
        [Display(Name ="Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter strong Password")]
        [Compare("ConfirmPassword",ErrorMessage ="Password does not Match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm your Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
