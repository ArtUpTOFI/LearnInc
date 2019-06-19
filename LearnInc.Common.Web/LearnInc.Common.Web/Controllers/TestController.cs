using System.Collections.Generic;
using AutoMapper;
using LearnInc.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnInc.Common.Web.Controllers
{
	[Route("api/[controller]")]
	public class TestController : Controller
	{
		private readonly ITestService _testService;

		public TestController(ITestService testService)
		{
			this._testService = testService;
		}

		[HttpGet("")]
		public IEnumerable<TestViewModel> GetTests()
		{
			var testModels = this._testService.GetTests();
			var results = Mapper.Map<IEnumerable<TestViewModel>>(testModels);

			return results;
		}
	}
}
