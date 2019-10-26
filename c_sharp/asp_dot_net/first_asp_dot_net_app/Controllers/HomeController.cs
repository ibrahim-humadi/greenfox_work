using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace first_asp_dot_net_app.Controllers
{
    public class HomeController : Controller
    {
		[Route("")]
		public string IActionResult Index()
        {
			string reply = "Hello from the Controller!";
			return reply;
		}
	}
}