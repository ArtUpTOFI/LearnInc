using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LearnInc.Common.Web.Controllers
{
	[Route("api/[controller]")]
	public class TestController : Controller
	{
		[HttpGet("")]
		public IEnumerable<TestViewModel> GetTests()
		{
			return new[] { new TestViewModel { TestId = Guid.Empty, TestText = "TEST" }};
		}
	}
}
