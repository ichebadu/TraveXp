using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userAuthentication_module.ViewModels
{
    public class VerifyEmailViewModel
    {
        [ Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email {get; set;}

        [StringLength(40, MinimumLength = 8, ErrorMessage = "the {0} must be at {2} and at max {1} character",)]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name ="Comfirm Password", ErrorMessage = "Password does not match")]
        [Compare("ComfirmNewPassword", ErrorMessage = "Password does not match")]
        public string NewPassword {get; set;}

        [Required(ErrorMessage = "Confirm new Password is required.")]
        [DataType(DataType.Password)]
        [Display(name ="Comfirm Password", ErrorMessage = "Password does not match")]
        public string ConfirmNewPassword {get; set;}

    }
    
}