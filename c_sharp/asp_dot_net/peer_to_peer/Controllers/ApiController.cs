using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace peer_to_peer.Controllers
{
	[Route("api")]
	[ApiController]
	public class ApiController : ControllerBase
	{

		[HttpPost]
		[Route("message/receive")]
		public ActionResult ReceiveMessage()
		{
			return Ok(new { message = "Success!" });
		}
	}
}
