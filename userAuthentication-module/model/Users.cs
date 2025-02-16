using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Net.Http.Headers;

namespace userAuthentication_module.model
{
    public class Users : IdentityUser
    {
        public string fullName{get; set;}
    }
}