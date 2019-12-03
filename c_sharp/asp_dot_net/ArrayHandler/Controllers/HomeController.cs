using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayHandler.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArrayHandler.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
    public class HomeController : Controller
    {

	 [HttpPost]
	 [Route("arrays")]
	 public IActionResult Index([FromBody] MathOp mathOp)
		{
			int[] resultArray = new int[mathOp.Numbers.Length];
			int intResult = 1;

			if (mathOp.Operation.Equals(Operation.sum))
			{ 
				return Json(new { result = mathOp.Numbers.Sum() });
			}
			if (mathOp.Operation.Equals(Operation.multiplyAll))
			{
				for (int i = 1; i < mathOp.Numbers.Length; i++)
				{
					intResult *= mathOp.Numbers[i];
				}
				return Json(new { result = intResult });
			}
			if (mathOp.Operation.Equals(Operation.multiplyElementsByTwo))
			{
				for (int i = 0; i < mathOp.Numbers.Length; i++)
				{
					resultArray[i] = mathOp.Numbers[i] * 2;
				}
				return Json(new { result = resultArray });
			}
			else
			{
				return Json(new { error = "Please provide what to do with the numbers!" });
			}
		}
	}
}