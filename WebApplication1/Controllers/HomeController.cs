using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("Home")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost("Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}