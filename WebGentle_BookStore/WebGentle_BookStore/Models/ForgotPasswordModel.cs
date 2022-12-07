using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Models
{
    public class ForgotPasswordModel
    {
        [Required, EmailAddress, Display(Name = "Registered Email Id")]
        public string Email { get; set; }
        public bool EmailSent { get; set; }
    }
}
