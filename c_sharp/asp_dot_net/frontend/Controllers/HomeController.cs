using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class HomeController : Controller
    {
		[Route("/")]
        public IActionResult Index()
        {
			return File("index.html", "text/html");
		}

		[HttpGet("/doubling")]
		public IActionResult Index(int? input)
		{
			var doubeled = input * 2;
			if (doubeled == null)
			{
				return Json(new { error = "Please provide an input!" } );
			}

			return Json(new { received = input, result = doubeled });
		}

		[HttpGet("/greeter")]
		public IActionResult Index([FromQuery]string name, string title)
		{
			if (title == "" || title == null && name == "" || name == null)
			{
				return Json(new { error = "Please provide a name and a title!", status = 400 });
			}
   
			if (title == "" || title == null)
			{
				return Json(new { error = "Please provide a title!", status = 400 });
			}

			if (name == "" || name == null)
			{
				return Json(new { error = "Please provide a name!", status = 400 });
			}

			return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
		}

		[HttpGet("/appenda/{appendable}")]
		public IActionResult Index(string appendable)
		{
			string appendA = appendable + "a";

			if (appendable == "" || appendable == null)
			{
				return Json(new { status = 404 });
			}
			else
			{
				return Json(new { appended = appendA });
			}
		}

		[HttpGet("/dountil/{action}")]
		public IActionResult Index(string action, int until)
		{
			int result = 0;

			if (action == "sum")
			{
				for (int i = 0; i < until; i++)
				{
					result = until;
					until -= 1;
				}
				return Json(new { result = result });
			}
			if (action == "factor")
			{
				for (int i = 0; i < until - 1; i++)
				{
					result = until * (until - i);
				}
				return Json(new { result = result });
			}
			return Json(new { error = "Please provide a number!" });
		}
	}
}