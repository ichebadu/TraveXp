using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userAuthentication_module.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email {get; set;}
        
        [StringLength(40, MinimumLength = 8, ErrorMessage = "the {0} must be at {2} and at max {1} character",)]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Compare("ComfirmPassword", ErrorMessage = "Password does not match")]
        public string Password {get; set;}

        [Required(ErrorMessage = "Confirm Password is required.")]
        public string ConfirmPassword {get; set;}
    }
}