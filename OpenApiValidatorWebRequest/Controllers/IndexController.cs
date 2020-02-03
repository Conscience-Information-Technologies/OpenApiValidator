using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenApiValidatorWebRequest.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IndexController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<string> Get()
		{
			return "You are welcome by Conscience IT OpenApi Dot-Net Validator";
		}
	}
}
