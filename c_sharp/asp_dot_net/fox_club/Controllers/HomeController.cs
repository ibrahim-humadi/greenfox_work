using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fox_club.Models;
using fox_club.Services;

namespace fox_club.Controllers
{
    public class HomeController : Controller
    {
		private Fox myFox;
		private Foxes foxes;

		public HomeController(Foxes foxes)
		{
			this.foxes = foxes;
		}

		[Route("")]
        public IActionResult Index()
        {
            return View();
        }

		[Route("Information")]
		public IActionResult Information(string name)
		{
			myFox = new Fox("","Grapes","Soda");
			myFox.Name = name;
			foxes.Add(myFox);
			return View(foxes);
		}

		[Route("Login")]
		public IActionResult Login()
		{
			return View();
		}
		
		[HttpPost("Login")]
		public IActionResult Login(string name)
		{
			foreach (var item in foxes.foxes)
			{
				if (item.Name == name)
				{
					return RedirectToAction("Information");
				}
			}
			return RedirectToAction("Information", new { name = name });
		}
	}
}