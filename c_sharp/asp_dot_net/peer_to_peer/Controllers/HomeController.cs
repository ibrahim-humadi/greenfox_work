using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using peer_to_peer.Models;
using peer_to_peer.Services;

namespace peer_to_peer.Controllers
{
    public class HomeController : Controller
    {
		private readonly ApplicationContext applicationContext;
		private readonly MsgService msgService;
		public static User loggedUser;
		public static string errorMsg;

		public HomeController(ApplicationContext applicationcontext, MsgService msgService)
		{
			this.applicationContext = applicationcontext;
			this.msgService = msgService;
			
		}

		[Route("/")]
		public IActionResult Home()
        {
            return View(loggedUser);
        }

		[Route("registration")]
		public IActionResult Registration()
		{
			return View();
		}

		[HttpPost("login")]
		public IActionResult Login(string username)
		{
			if (applicationContext.Users.FirstOrDefault(x => x.Username == username) != null)
			{
				loggedUser = applicationContext.Users.FirstOrDefault(x => x.Username == username);
				return RedirectToAction("Home");
			}
			else
			{
				return RedirectToAction("Registration");
			}
		}

		[HttpPost("register")]
		public IActionResult Registration(string username)
		{
			if (applicationContext.Users.FirstOrDefault(x => x.Username == username) == null)
			{
				User newUser = new User();
				newUser.Username = username;
				applicationContext.Users.Add(newUser);
				applicationContext.SaveChanges();
				loggedUser = newUser;
			}
			else
			{
				loggedUser = applicationContext.Users.FirstOrDefault(x => x.Username == username);
				errorMsg = "This Username already exists, Please login.";
				return View((object)errorMsg);
			}
			return RedirectToAction("Home");
		}

		[HttpPost("postmsg")]
		public async Task<ActionResult> PostMsg(string message)
		{
			await msgService.PostAsync("Hello");

			return RedirectToAction("Home");
		}
	}
}