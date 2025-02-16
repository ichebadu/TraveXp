using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userAuthentication_module.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}