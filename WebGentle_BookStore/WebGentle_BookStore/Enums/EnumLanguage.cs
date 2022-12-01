using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Enums
{ 
    public enum EnumLanguage
    {
        [Display(Name ="Hindi Language")]
        Hindi=10,
        [Display(Name = "Kannada Language")]
        Kannada=11,
        [Display(Name = "English Language")]
        English=12,
        [Display(Name = "Tamil Language")]
        Tamil=13,
        [Display(Name = "Telugu Language")]
        Telugu=14,
        [Display(Name = "French Language")]
        French=15
    }
}
