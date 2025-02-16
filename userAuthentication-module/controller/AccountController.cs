using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace userAuthentication_module.controller
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}