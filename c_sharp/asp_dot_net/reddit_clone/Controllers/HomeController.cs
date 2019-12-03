using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reddit_clone.Models;
using Microsoft.EntityFrameworkCore;

namespace reddit_clone.Controllers
{
    public class HomeController : Controller
    {
		private readonly ApplicationContext applicationContext;
		private User loggedUser;

		public HomeController(ApplicationContext applicationcontext)
		{
			this.applicationContext = applicationcontext;
		}

		[Route("/")]
		public IActionResult Index()
        {
			var posts = applicationContext.Posts.Include(post => post.Creator).ToList();

            return View(posts);
        }

		[Route("/add")]
		public IActionResult AddPost()
		{
			return View();
		}

		[HttpGet("/add/newpost")]
		public IActionResult AddPost(string title, string description)
		{
			Post tempPost = new Post(title, 0, description);
			tempPost.Creator = applicationContext.User.FirstOrDefault(x => x.Id == 1);
			applicationContext.Posts.Add(tempPost);
			applicationContext.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpGet("/login")]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost("/login")]
		public IActionResult Login(string username)
		{
			if (applicationContext.User.FirstOrDefault(x => x.UserName == username) == null)
			{
				User newUser = new User();
				newUser.UserName = username;
				applicationContext.User.Add(newUser);
				applicationContext.SaveChanges();
				loggedUser = newUser;
			}

			loggedUser = applicationContext.User.FirstOrDefault(x => x.UserName == username);

			return RedirectToAction("index");
		}


	}
}