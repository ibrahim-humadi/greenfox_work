using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace array_handker_second_without_class_method.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : Controller
	{
		// GET api/values
		[HttpPost("arrays")]
		public ActionResult Get([FromBody]JObject jsonObj)
		{
			dynamic test = jsonObj;
			var test2 = test.numbers.ToObject<int[]>();
			int result = 0;

			if (jsonObj.Value<string>("what") == "sum")
			{
				foreach (var item in test2)
				{
					result += item;
				}
				return Json(new { result = result });
			}
			if (jsonObj.Value<string>("what") == "multiply")
			{
				result = 1;
				foreach (var item in test2)
				{
					result *= item;
				}
				return Json(new { result = result });
			}
			if (jsonObj.Value<string>("what") == "double")
			{
				int arrayLength = 0;
				int x = 0;
				foreach (var item in test2)
				{
					arrayLength++;
				}
				int[] resultArray = new int[arrayLength];
				foreach (var item in test2)
				{
					resultArray[x] = item * 2;
					x++;
				}
				return Json(new { result = resultArray });

			}
			else
			{
				return Json(new { error = "fuck off" });
			}
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
